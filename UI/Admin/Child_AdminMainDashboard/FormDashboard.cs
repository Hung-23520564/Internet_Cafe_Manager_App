using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.Timer;
using Internet_Cafe_Manager_App.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.DataAnnotations;

namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    public partial class FormDashboard : Form
    {


        private BindingList<PC> pcList;


        public FormDashboard()
        {
            InitializeComponent();
           
            // Này là để khởi tạo phương thức Active nghen mấy ní, để tui note lại cho Hưng và Hồng Huy đọc cho dễ hiểu. Cái này tui thấy lú lú á hai fen, note lại cho chắc, sau cô có hỏi thì còn nhớ :)))
            // Lý do cần phương thức ACtivated là vì :
            // - System.Windows.Forms.Timer hoạt động dựa trên luồng UI (UI thread) của ứng dụng Windows Forms. Nó phụ thuộc vào "message loop" của Form để kích hoạt sự kiện Tick
            // - Khi Form của bạn không hoạt động (ví dụ: bạn thu nhỏ cửa sổ, hoặc một cửa sổ khác che phủ hoàn toàn Form), hệ điều hành có thể tạm dừng hoặc giảm ưu tiên xử lý các thông báo cho luồng UI của Form đó để tiết kiệm tài nguyên
            // - Khi luồng UI bị tạm dừng hoặc hoạt động chậm, các sự kiện Tick của System.Windows.Forms.Timer cũng có thể bị trễ hoặc không được kích hoạt đúng lúc
            // - Để cột "TimeUsed" hiển thị giá trị đúng ngay lập tức khi bạn quay lại Form, bạn có thể xử lý sự kiện Activated của Form. Sự kiện này xảy ra mỗi khi Form trở thành cửa sổ hoạt động. Trong sự kiện này, bạn chỉ cần buộc DataGridView cập nhật lại hiển thị cho các dòng đang chạy
            this.Activated += FormDashboard_Activated;


            pcList = new BindingList<PC>();

            dataGridViewPCs.DataSource = this.pcList;

            LoadPCsFromFirebase();

            comboBoxEditStatus.DataSource = Enum.GetValues(typeof(PCStatus));

            dataGridViewPCs.EnableHeadersVisualStyles = false;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPCs.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dataGridViewPCs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewPCs.ColumnHeadersHeight = 30;
            dataGridViewPCs.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewPCs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewPCs.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPCs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewPCs.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewPCs.BackgroundColor = Color.White;
            dataGridViewPCs.RowHeadersVisible = false;
            dataGridViewPCs.CellBorderStyle = DataGridViewCellBorderStyle.None;




            if (dataGridViewPCs.Columns.Contains("Name"))
            {

                dataGridViewPCs.Columns["Name"].FillWeight = 80;
            }
            if (dataGridViewPCs.Columns.Contains("DetailInfo"))
            {

                dataGridViewPCs.Columns["DetailInfo"].FillWeight = 140;
            }
            if (dataGridViewPCs.Columns.Contains("Status"))
            {

                dataGridViewPCs.Columns["Status"].FillWeight = 70;
            }
            if (dataGridViewPCs.Columns.Contains("CurrentUser"))
            {

                dataGridViewPCs.Columns["CurrentUser"].FillWeight = 120;
            }
            if (dataGridViewPCs.Columns.Contains("StartTime"))
            {

                dataGridViewPCs.Columns["StartTime"].DefaultCellStyle.Format = "HH:mm:ss";
                dataGridViewPCs.Columns["StartTime"].FillWeight = 90;
            }
            if (dataGridViewPCs.Columns.Contains("TimeRemaining"))
            {

                dataGridViewPCs.Columns["TimeRemaining"].DefaultCellStyle.Format = @"hh\:mm\:ss";
                dataGridViewPCs.Columns["TimeRemaining"].FillWeight = 130;
            }
            if (dataGridViewPCs.Columns.Contains("TimeUsed"))
            {

                dataGridViewPCs.Columns["TimeUsed"].DefaultCellStyle.Format = @"hh\:mm\:ss";
                dataGridViewPCs.Columns["TimeUsed"].FillWeight = 90;
            }




            dataGridViewPCs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




        }




        private async void buttonAddPC_Click(object sender, EventArgs e)
        {
            string sequenceNumberText = textBoxSequenceNumber.Text.Trim();
            if (string.IsNullOrEmpty(sequenceNumberText))
            {
                MessageBox.Show("Vui lòng nhập số thứ tự máy.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSequenceNumber.Focus();
                return;
            }

            int sequenceNumber;
            bool isNumeric = int.TryParse(sequenceNumberText, out sequenceNumber);

            if (!isNumeric || sequenceNumber <= 0)
            {
                MessageBox.Show("Số thứ tự máy không hợp lệ. Vui lòng nhập một số nguyên dương.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSequenceNumber.Focus();
                textBoxSequenceNumber.SelectAll();
                return;
            }

            string pcName = $"PC{sequenceNumber}";

            if (pcList.Any(pc => pc.Name.Equals(pcName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Máy '{pcName}' đã tồn tại trong hệ thống.", "Trùng tên máy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSequenceNumber.Focus();
                textBoxSequenceNumber.SelectAll();
                return;
            }

            PC newPC = new PC(pcName)
            {
                Status = PCStatus.Available,
                DetailInfo = "Máy mới",

            };

            pcList.Add(newPC); // Thêm vào list

            // *** LƯU PC MỚI LÊN FIREBASE ***
            FirebaseDB firebaseDB = new FirebaseDB(); // Tạo instance
            bool saveSuccess = await firebaseDB.AddOrUpdatePC(newPC);
            if (saveSuccess)
            {
                MessageBox.Show($"Đã thêm và lưu máy '{pcName}' vào hệ thống.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Đã thêm máy '{pcName}' vào danh sách tạm nhưng không lưu được lên Firebase!", "Lỗi Lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Cần xử lý lỗi lưu trữ (ví dụ: thử lại, thông báo cho Admin)
            }

            Debug.WriteLine($"pcList count after adding: {pcList.Count}");



            MessageBox.Show($"Đã thêm máy '{pcName}' vào hệ thống.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxSequenceNumber.Clear();
            textBoxSequenceNumber.Focus();

        }


        private void buttonClearAddPC_Click(object sender, EventArgs e)
        {
            textBoxSequenceNumber.Clear();
            textBoxSequenceNumber.Focus();
        }

        private void textBoxEditPCName_Leave(object sender, EventArgs e)
        {
            string sequenceNumberText = textBoxEditPCName.Text.Trim();
            ClearEditFields();

            if (string.IsNullOrEmpty(sequenceNumberText))
            {
                return;
            }

            int sequenceNumber;
            bool isNumeric = int.TryParse(sequenceNumberText, out sequenceNumber);
            if (!isNumeric || sequenceNumber <= 0)
            {
                MessageBox.Show("Số thứ tự máy không hợp lệ. Vui lòng nhập một số nguyên dương.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEditPCName.Focus();
                textBoxEditPCName.SelectAll();
                return;
            }
            string pcNameToFind = $"PC{sequenceNumber}";

            PC foundPC = pcList.FirstOrDefault(pc => pc.Name.Equals(pcNameToFind, StringComparison.OrdinalIgnoreCase));
            if (foundPC != null)
            {
                textBoxEditDetailInfo.Text = foundPC.DetailInfo;
                textBoxEditCurrentUser.Text = foundPC.CurrentUser;
                comboBoxEditStatus.SelectedItem = foundPC.Status;
                textBoxEditSoTien.Text = foundPC.Budget.ToString();
            }
            else
            {

                MessageBox.Show($"Không tìm thấy máy '{pcNameToFind}' trong danh sách.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEditPCName.Focus();
                textBoxEditPCName.SelectAll();
            }


        }
        

        private void ClearEditFields()
        {

            textBoxEditDetailInfo.Clear();
            textBoxEditCurrentUser.Clear();
            if (comboBoxEditStatus.Items.Count > 0)
            {
                comboBoxEditStatus.SelectedIndex = 0;
            }
            textBoxEditSoTien.Clear();

        }

        private async void buttonEditSave_Click(object sender, EventArgs e)
        {
            
            string NumberFromTextBox = textBoxEditPCName.Text.Trim();
            string pcNameToSave = $"PC{NumberFromTextBox}";

            if (string.IsNullOrEmpty(pcNameToSave))
            {
                MessageBox.Show("Vui lòng nhập số thứ tự máy cần cập nhật.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEditPCName.Focus();
                return;
            }

            
            PC pcToUpdate = pcList.FirstOrDefault(pc => pc.Name.Equals(pcNameToSave, StringComparison.OrdinalIgnoreCase));

            if (pcToUpdate != null)
            {
                
                string newCurrentUser = textBoxEditCurrentUser.Text.Trim();
                PCStatus newStatus = (PCStatus)comboBoxEditStatus.SelectedItem;
                string detailInfo = textBoxEditDetailInfo.Text.Trim();
                int budget = 0;
                
                if (!string.IsNullOrEmpty(textBoxEditSoTien.Text.Trim()))
                {
                    if (!int.TryParse(textBoxEditSoTien.Text.Trim(), out budget))
                    {
                        MessageBox.Show("Số tiền không hợp lệ. Vui lòng nhập một số nguyên.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxEditSoTien.Focus();
                        textBoxEditSoTien.SelectAll();
                        return; 
                    }
                }




                // --- Logic xử lý Budget và TimeRemaining ---
                int oldBudget = pcToUpdate.Budget; // Lấy Budget cũ để so sánh

                // Cập nhật Budget
                pcToUpdate.Budget = budget;

                // Tính toán tổng thời gian được dùng từ Budget mới
                TimeSpan totalTimeFromNewBudget = PC.CalculateTotalTimeFromBudget(budget);

                // Nếu Budget tăng, thêm thời gian tương ứng vào TimeRemaining
                if (budget > oldBudget)
                {
                    // Thời gian thêm vào = Thời gian từ Budget mới - Thời gian từ Budget cũ
                    // (Hoặc đơn giản hơn là chỉ tính thời gian từ phần Budget TĂNG THÊM
                    // và cộng vào TimeRemaining hiện tại nếu muốn hỗ trợ nạp thêm giờ)
                    // Cách đơn giản nhất là tính lại tổng thời gian từ budget mới và gán vào TimeRemaining
                    pcToUpdate.TimeRemaining = totalTimeFromNewBudget;

                    // Nếu máy đang ở trạng thái rảnh hoặc hết giờ và có Budget mới > 0,
                    // thì bắt đầu phiên sử dụng
                    if ((pcToUpdate.Status == PCStatus.Available || pcToUpdate.Status == PCStatus.TimeEnded) && budget > 0)
                    {
                        pcToUpdate.Status = PCStatus.InUse;
                        pcToUpdate.StartTime = DateTime.Now;
                        pcToUpdate.CurrentUser = newCurrentUser; // Gán người dùng khi bắt đầu dùng
                                                                 // Reset TimeUsed (nếu cần, mặc dù getter đã tính từ StartTime)
                                                                 // pcToUpdate.OnPropertyChanged(nameof(pcToUpdate.TimeUsed)); // Thông báo TimeUsed thay đổi
                    }
                }
                else if (budget < oldBudget)
                {
                    // Xử lý khi Budget giảm (tùy quy tắc kinh doanh của bạn)
                    // Có thể trừ bớt TimeRemaining hoặc không làm gì
                    // Ví dụ: Chỉ đơn giản là tính lại TimeRemaining từ Budget mới
                    pcToUpdate.TimeRemaining = totalTimeFromNewBudget;

                    // Nếu Budget về 0 và đang InUse, kết thúc phiên
                    if (budget <= 0 && pcToUpdate.Status == PCStatus.InUse)
                    {
                        pcToUpdate.Status = PCStatus.TimeEnded;
                        pcToUpdate.StartTime = null; // Kết thúc phiên, xóa StartTime
                        pcToUpdate.CurrentUser = null; // Xóa người dùng
                        pcToUpdate.TimeRemaining = TimeSpan.Zero; // Hết giờ
                    }
                }
                else // Budget không đổi
                {
                    // Nếu Budget không đổi nhưng trạng thái hoặc người dùng thay đổi
                    // Cập nhật Status và CurrentUser như bình thường
                    pcToUpdate.Status = newStatus; // Có thể cho phép đổi trạng thái thủ công
                    pcToUpdate.CurrentUser = newCurrentUser;
                    // Nếu bạn cho phép set Status = InUse khi Budget không đổi,
                    // hãy kiểm tra và set StartTime nếu cần
                    if (newStatus == PCStatus.InUse && !pcToUpdate.StartTime.HasValue)
                    {
                        pcToUpdate.StartTime = DateTime.Now;
                    }
                    else if (newStatus != PCStatus.InUse && pcToUpdate.StartTime.HasValue)
                    {
                        pcToUpdate.StartTime = null; // Xóa StartTime nếu không còn InUse
                    }
                }
                // --- Kết thúc Logic xử lý Budget và TimeRemaining ---



                pcToUpdate.CurrentUser = newCurrentUser;
                pcToUpdate.Status = newStatus;
                pcToUpdate.DetailInfo = detailInfo;
                pcToUpdate.Budget = budget;
                if (pcToUpdate.CurrentUser != null && pcToUpdate.Status == PCStatus.InUse && pcToUpdate.Budget != null)
                {
                    pcToUpdate.StartTime = DateTime.Now;
                }
                    


                

                MessageBox.Show($"Đã cập nhật thông tin cho máy '{pcToUpdate.Name}'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }

            else
            {
                
                MessageBox.Show($"Không tìm thấy máy '{pcNameToSave}' để cập nhật. Vui lòng nhập đúng số thứ tự máy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

            // *** LƯU PC ĐÃ CẬP NHẬT LÊN FIREBASE ***
            FirebaseDB firebaseDB = new FirebaseDB(); // Tạo instance
            bool saveSuccess = await firebaseDB.AddOrUpdatePC(pcToUpdate); // Dùng AddOrUpdatePC để cập nhật

            if (saveSuccess)
            {
                MessageBox.Show($"Đã cập nhật và lưu thông tin cho máy '{pcToUpdate.Name}'.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // BindingList sẽ tự động cập nhật DataGridView khi pcToUpdate thay đổi
            }
            else
            {
                MessageBox.Show($"Đã cập nhật thông tin máy '{pcToUpdate.Name}' trong danh sách tạm nhưng không lưu được lên Firebase!", "Lỗi Lưu trữ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Cần xử lý lỗi lưu trữ
            }

            textBoxEditPCName.Clear();
            textBoxEditDetailInfo.Clear();
            textBoxEditCurrentUser.Clear();
            textBoxEditSoTien.Clear();
            textBoxEditPCName.Focus();
            comboBoxEditStatus.SelectedItem = PCStatus.Available;
        }

        private void buttonEditClear_Click(object sender, EventArgs e)
        {
            textBoxEditPCName.Clear();
            textBoxEditDetailInfo.Clear();
            textBoxEditCurrentUser.Clear();
            textBoxEditSoTien.Clear();
            textBoxEditPCName.Focus();
            comboBoxEditStatus.SelectedItem = PCStatus.Available;
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            List<PC> pcsToSave = new List<PC>();

            foreach (var pc in pcList)
            {
                
                if (pc.Status == PCStatus.InUse && pc.StartTime.HasValue)
                {
                    
                    pc.NotifyTimeUsedChanged();

                    if (pc.TimeRemaining.HasValue && pc.TimeRemaining.Value > TimeSpan.Zero)
                    {
                        
                        pc.DecrementTimeRemaining(TimeSpan.FromMilliseconds(timer1.Interval));
                        
                    }

                    if (pc.Status == PCStatus.TimeEnded) // Điều kiện này đã được xử lý trong DecrementTimeRemaining
                    {
                        // Đảm bảo logic khi hết giờ được xử lý đúng (StartTime = null, CurrentUser = null, Budget = 0)
                        pc.StartTime = null;
                        pc.CurrentUser = null;
                        // Không đặt Budget về 0 ở đây trừ khi đó là quy tắc của bạn
                        pc.TimeRemaining = TimeSpan.Zero;

                        // Đánh dấu PC này cần được lưu lên Firebase
                        pcsToSave.Add(pc);
                    }


                }
                
            }

            // *** LƯU CÁC PC CÓ THAY ĐỔI TRẠNG THÁI QUAN TRỌNG LÊN FIREBASE ***
            if (pcsToSave.Count > 0)
            {
                FirebaseDB firebaseDB = new FirebaseDB(); // Tạo instance
                foreach (PC pcToSave in pcsToSave)
                {
                    bool saveSuccess = await firebaseDB.AddOrUpdatePC(pcToSave);
                    if (!saveSuccess)
                    {
                        Console.WriteLine($"Lỗi: Không lưu được trạng thái PC '{pcToSave.Name}' lên Firebase.");
                        // Có thể cần hiển thị thông báo lỗi hoặc thử lại
                    }
                }
            }

        }


        private void FormDashboard_Activated(object sender, EventArgs e)
        {
            // Khi Form được kích hoạt, yêu cầu cập nhật lại TimeUsed cho các máy đang chạy
            if (pcList != null)
            {
                foreach (var pc in pcList)
                {
                    if (pc.Status == PCStatus.InUse && pc.StartTime.HasValue)
                    {
                        // Gọi phương thức trong đối tượng PC để nó tự thông báo thay đổi TimeUsed
                        pc.NotifyTimeUsedChanged();
                    }
                }
            }
        }

        private async void LoadPCsFromFirebase()
        {
            // Tạo instance của FirebaseDB
            FirebaseDB firebaseDB = new FirebaseDB();

            // Tạm thời xóa dữ liệu cũ trong list hiển thị
            pcList.Clear();

            try
            {
                // Lấy dữ liệu từ Firebase
                List<PC> loadedPCs = await firebaseDB.GetAllPCs();

                // Kiểm tra nếu có dữ liệu được tải về
                if (loadedPCs != null)
                {
                    // Lặp qua từng PC được tải về
                    foreach (PC pc in loadedPCs)
                    {
                        // *** DI CHUYỂN LOGIC TÍNH TOÁN VÀO BÊN TRONG VÒNG LẶP ***
                        // Chỉ tính toán lại TimeRemaining cho các máy đang được sử dụng
                        if (pc.Status == PCStatus.InUse && pc.StartTime.HasValue)
                        {
                            // 1. Tính tổng thời gian của phiên dựa trên Budget đã lưu
                            // Đảm bảo Budget có giá trị hợp lệ (ví dụ: >= 0)
                            TimeSpan totalSessionTime = PC.CalculateTotalTimeFromBudget(pc.Budget >= 0 ? pc.Budget : 0);

                            // 2. Tính thời gian đã trôi qua kể từ StartTime đến thời điểm HIỆN TẠI
                            // Sử dụng DateTime.Now để tính thời gian thực tế đã trôi qua
                            TimeSpan timeElapsed = DateTime.Now - pc.StartTime.Value;

                            // 3. Tính thời gian còn lại thực tế
                            TimeSpan actualTimeRemaining = totalSessionTime - timeElapsed;

                            // 4. Gán thời gian còn lại thực tế này vào thuộc tính TimeRemaining của đối tượng PC
                            // Đảm bảo giá trị không âm
                            pc.TimeRemaining = (actualTimeRemaining > TimeSpan.Zero) ? actualTimeRemaining : TimeSpan.Zero;

                            // Tùy chọn: Nếu thời gian còn lại <= 0 sau khi tính toán, cập nhật trạng thái ngay
                            // Điều này xử lý trường hợp máy hết giờ khi ứng dụng Admin đóng
                            if (pc.TimeRemaining.Value <= TimeSpan.Zero && pc.Status != PCStatus.TimeEnded)
                            {
                                pc.Status = PCStatus.TimeEnded;
                                pc.StartTime = null; // Kết thúc phiên
                                pc.CurrentUser = null; // Xóa người dùng
                                pc.TimeRemaining = TimeSpan.Zero; // Đảm bảo là 0
                                                                  // Cân nhắc lưu lại trạng thái này lên Firebase ngay nếu bạn thay đổi ở đây
                                                                  // FirebaseDB dbToSave = new FirebaseDB();
                                                                  // await dbToSave.AddOrUpdatePC(pc);
                            }
                        }
                        // *** KẾT THÚC LOGIC TÍNH TOÁN ***

                        // Thêm đối tượng PC (đã được cập nhật TimeRemaining nếu cần) vào BindingList
                        pcList.Add(pc);
                    }
                }

                // Cập nhật lại DataGridView (BindingList tự động cập nhật, nhưng Refresh() cũng không hại)
                dataGridViewPCs.Refresh();
                Console.WriteLine($"Đã tải {pcList.Count} PC từ Firebase."); // Debug log
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi tải dữ liệu từ Firebase
                MessageBox.Show($"Lỗi khi tải dữ liệu PC từ Firebase: {ex.Message}", "Lỗi Tải Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Chi tiết lỗi tải dữ liệu PC: {ex}"); // Log chi tiết lỗi
            }
        }


    }
}