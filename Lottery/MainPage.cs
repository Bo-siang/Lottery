using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class MainPage : Form
    {
        public List<Button> A1Buttons = new List<Button>();//第一區選號按鈕
        public List<Button> A2Buttons = new List<Button>(); //第二區選號按鈕
        public List<List<int>> selectedNums = new List<List<int>>(); //選號
        public List<int> tempSelectedNums = new List<int>(); //第一區暫存選號
        int a2Num; //第二區暫存選號
        public List<int> winNums = new List<int>(); //中獎號碼
        public List<int> sortedWinNums = new List<int>(); //排序過後的中獎號碼
        Random random = new Random(); //隨機數物件
        int cntA1 = 0; //紀錄使用者選了幾個第一區號碼
        int cntA2 = 0; //紀錄使用者選了幾個第二區號碼
        int totalCost = 0; //紀錄使用者買彩券的總花費 
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            GenerateButtonA1(5, 8);
            GenerateButtonA2(1, 8);
        }


        void GenerateButtonA1(int row, int column)
        {
            int 號碼 = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if(號碼 > 38) 
                    { 
                        break; 
                    }
                    Button ButtonA1 = new Button();
                    ButtonA1.BackColor = Color.LavenderBlush;
                    ButtonA1.ForeColor = Color.Gray;
                    ButtonA1.Font = new Font("微軟正黑體", 12);
                    ButtonA1.Location = new Point(25 + 40 * j, 50 + 30 * i); //行x是內層迴圈決定，列y是外層迴圈決定
                    ButtonA1.Size = new Size(35, 25);
                    ButtonA1.Text = 號碼.ToString();
                    ButtonA1.Click += new EventHandler(ButtonA1_Click); //+=事件指定運算子、-=事件移除運算子
                    Controls.Add(ButtonA1);
                    號碼++;
                    A1Buttons.Add(ButtonA1);
                }
            }
        }

        void GenerateButtonA2(int row, int column)
        {
            int 號碼 = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Button ButtonA2 = new Button();
                    ButtonA2.BackColor = Color.LavenderBlush;
                    ButtonA2.ForeColor = Color.Gray;
                    ButtonA2.Font = new Font("微軟正黑體", 12);
                    ButtonA2.Location = new Point(25 + 40 * j, 250 + 30 * i); //行x是內層迴圈決定，列y是外層迴圈決定
                    ButtonA2.Size = new Size(35, 25);
                    ButtonA2.Text = 號碼.ToString();
                    ButtonA2.Click += new EventHandler(ButtonA2_Click); //+=事件指定運算子、-=事件移除運算子
                    Controls.Add(ButtonA2);
                    號碼++;
                    A2Buttons.Add(ButtonA2);
                }
            }
        }

        private void ButtonA1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (btn.BackColor == Color.LavenderBlush) //如果按鈕顏色為粉紅色
            {
                if (cntA1 < 6) //且第一區選號數量不大於6
                {
                    btn.BackColor = Color.Gold; //將按鈕改為金色
                    cntA1++; //將第一區的選號數加一
                    tempSelectedNums.Add(Convert.ToInt32(btn.Text)); //插入所選數字至tempSelectedNums
                }
                else
                {
                    MessageBox.Show("已超過六個選號!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (btn.BackColor == Color.Gold) //如果按鈕顏色為金黃色
            {
                btn.BackColor = Color.LavenderBlush; //將按鈕改為粉紅色
                cntA1--; //將第一區的選號數減一
                tempSelectedNums.Remove(Convert.ToInt32(btn.Text)); //從tempSelectedNums移除所選數字
            }
        }

        private void ButtonA2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.LavenderBlush) //如果按鈕顏色為粉紅色
            {
                if (cntA2 < 1) //且第一區選號數量不大於1
                {
                    btn.BackColor = Color.Gold; //將按鈕改為金色
                    a2Num = Convert.ToInt32(btn.Text); //將所選數字存放在a2Num
                    cntA2++; //將第二區的選號數加一

                }
                else
                {
                    MessageBox.Show("已超過一個選號!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (btn.BackColor == Color.Gold) //如果按鈕顏色為金黃色
            {
                btn.BackColor = Color.LavenderBlush; //將按鈕改為粉紅色
                a2Num = 0; //將所選數字設為0
                cntA2--; //將第二區的選號數減一
            }
        }

        public bool checkDuplicated()
        {
            for (int i = 0; i < selectedNums.Count(); i++)
            {
                int duplicatedCnt = 0;
                for (int j = 0; j <= 5; j++)
                {
                    if (selectedNums[i].GetRange(0, 6).Contains(tempSelectedNums[j]))
                    {
                        duplicatedCnt++;
                    }
                }
                if (selectedNums[i][6] == tempSelectedNums[6])
                {
                    duplicatedCnt++;
                }
                if (duplicatedCnt == 7)
                {
                    MessageBox.Show("已有相同組號，請重新選號!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foreach (Button btn in A1Buttons)
                    {
                        btn.BackColor = Color.LavenderBlush;
                    }
                    foreach (Button btn in A2Buttons)
                    {
                        btn.BackColor = Color.LavenderBlush;
                    }
                    cntA1 = 0;
                    cntA2 = 0;
                    tempSelectedNums.Clear();
                    a2Num = 0;
                    return true;
                }
            }
            return false;
        }

        //顯示使用者採用的選號模式- 自行選號模式、部分快選模式、全部快選模式
        public void showMode(string msg, Color bgColor)
        {
            ModeNotification md = new ModeNotification(msg, bgColor);
            md.Show();
        }

        private void btn加入組號_Click(object sender, EventArgs e)
        {
            string item = $"第 {listBox選號紀錄.Items.Count + 1} 組:"; //組號是listbox元素數量 + 1

            if (cntA1 == 6 && cntA2 == 1) //自行選號
            {
                showMode("自行選號模式", Color.DarkRed);
                tempSelectedNums.Add(a2Num); //將第二區選號加入暫存選號
                //確認使用者未下注同樣組號
                bool isDupulicated = checkDuplicated();
                if (isDupulicated == true)
                {
                    return;
                }
                selectedNums.Add(tempSelectedNums.GetRange(0, 7)); //將暫存選號串列中的7個號碼淺複製給選號串列
                //遍歷新加入的組號並加入到item字串
                for (int i = 0; i <= 6; i++) 
                {
                    item += $"{selectedNums[selectedNums.Count() - 1][i].ToString(),5}";
                }
                listBox選號紀錄.Items.Add(item); //將item字串加入至listbox中
                totalCost += 100; //花費金額加上100
            }
            else if (cntA1 == 0 && cntA2 == 0) //全部快選
            {
                showMode("全部快選模式", Color.DarkRed);
                for (int i = 0; i <= 6; i++)
                {
                    if (i == 6)
                    {
                        tempSelectedNums.Add(random.Next(1, 9)); //第二區選號範圍是1-8
                    }
                    tempSelectedNums.Add(random.Next(1, 39)); //第一區選號範圍是1-38
                    if (i != 0 && i != 6) //第一區的第一個選號與第二區的選號無須檢查重覆值
                    {
                        while (tempSelectedNums.GetRange(0, i).Contains(tempSelectedNums[i])) //若(當前元素-1)的元素中有包含當前元素
                        {
                            tempSelectedNums.RemoveAt(i); //就刪除當前元素
                            tempSelectedNums.Add(random.Next(1, 39)); //並重新產生一個數字
                        }
                    }
                }
                //確認使用者未下注同樣組號
                bool isDupulicated = checkDuplicated();
                if (isDupulicated == true)
                {
                    return;
                }
                selectedNums.Add(tempSelectedNums.GetRange(0, 7)); //將暫存選號串列中的7個號碼淺複製給選號串列

                for (int i = 0; i <= 6; i++)
                {
                    item += $"{selectedNums[listBox選號紀錄.Items.Count][i].ToString(),5}";
                }
                listBox選號紀錄.Items.Add(item);
                totalCost += 100;
            }
            else //部分快選
            {
                showMode("部分快選模式", Color.DarkRed);
                int a1 = 6 - cntA1; //計算第一區不足的選號數量
                int a2 = 1 - cntA2; //計算第二區不足的選號數量

                for (int i = 0; i < a1; i++)
                {
                    tempSelectedNums.Add(random.Next(1, 39)); //第一區選號範圍是1-38
                    cntA1++;
                    while (tempSelectedNums.GetRange(0, cntA1 - 1).Contains(tempSelectedNums[tempSelectedNums.Count() - 1])) //若使用者選的元素中有包含當前元素
                    {
                        tempSelectedNums.RemoveAt(tempSelectedNums.Count() - 1); //就刪除當前元素
                        tempSelectedNums.Add(random.Next(1, 39)); //並重新產生一個數字
                    }
                }
                if (a2 != 0)
                {
                    tempSelectedNums.Add(random.Next(1, 9)); //第一區選號範圍是1-9
                }
                else
                {
                    tempSelectedNums.Add(a2Num);
                }
                //確認使用者未下注同樣組號
                bool isDupulicated = checkDuplicated();
                if (isDupulicated == true)
                {
                    return;
                }
                selectedNums.Add(tempSelectedNums.GetRange(0, 7));
                for (int i = 0; i <= 6; i++)
                {
                    item += $"{selectedNums[listBox選號紀錄.Items.Count][i].ToString(),5}";
                }
                listBox選號紀錄.Items.Add(item);
                totalCost += 100;
            }

            //選完號後進行初始設置 
            cntA1 = 0;
            cntA2 = 0;
            tempSelectedNums.Clear();
            a2Num = 0;

            foreach (Button btn in A1Buttons)
            {
                btn.BackColor = Color.LavenderBlush;
            }
            foreach (Button btn in A2Buttons)
            {
                btn.BackColor = Color.LavenderBlush;
            }
        }
        

        private void btn刪除所選選號_Click(object sender, EventArgs e)
        {
            //多選模式
            if (listBox選號紀錄.SelectedIndices.Count > 0)
            {
                for (int i = (listBox選號紀錄.SelectedIndices.Count - 1); i >= 0; i--)
                {
                    int toBeRemoved = listBox選號紀錄.SelectedIndices[i];
                    listBox選號紀錄.Items.RemoveAt(toBeRemoved);
                    selectedNums.RemoveAt(toBeRemoved);
                    totalCost -= 100;
                }

                //重整選單紀錄編號
                for (int i = 0; i < selectedNums.Count(); i++)
                {
                    string selection = $"第 {i + 1} 組: ";
                    for (int j = 0; j <= 6; j++)
                    {
                        selection += $"{selectedNums[i][j], 5}";
                    }
                    listBox選號紀錄.Items[i] = selection;
                }
            }
            else
            {
                MessageBox.Show("請選擇欲刪除的組號!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn刪除全部選號_Click(object sender, EventArgs e)
        {
            if (listBox選號紀錄.Items.Count != 0)
            {
                DialogResult deleteOrNot = MessageBox.Show("確定要刪除全部組號嗎?", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (deleteOrNot == DialogResult.Yes)
                {
                    listBox選號紀錄.Items.Clear();
                    selectedNums.Clear();
                    totalCost = 0;
                }
            }
            else
            {
                MessageBox.Show("無任何組號可刪除!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btn確認對獎_Click(object sender, EventArgs e)
        {
            //防止使用者未加入組號就對獎
            if (listBox選號紀錄.Items.Count == 0)
            {
                MessageBox.Show("請先加入組號!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //每次開獎前先清空之前的開獎紀錄
            winNums.Clear(); 
            sortedWinNums.Clear(); 

            //產生中獎號碼
            for (int i = 0; i <= 6; i++)
            {
                if (i == 6)
                {
                    winNums.Add(random.Next(1, 9)); //第二區獎號範圍是1-8 
                }
                else
                {
                    winNums.Add(random.Next(1, 39)); //第一區獎號範圍是1-38
                }
                
                if (i != 0 && i != 6) //第一區開出的第一個獎號與第二區開出的獎號無須檢查重覆值
                {
                    while (winNums.GetRange(0, i).Contains(winNums[i])) //若當前元素之前的元素中有包含當前元素
                    {
                        winNums.RemoveAt(i); //就刪除當前元素
                        winNums.Add(random.Next(1, 39)); //並重新產生一個數字
                    }
                } 
                foreach (int num in winNums)
                {
                    Console.WriteLine(num);
                }
            }
            sortedWinNums.AddRange(winNums.GetRange(0, 6)); //將開出的第一區獎號淺拷貝給sortedWinNums
            sortedWinNums.Sort(); //將第一區獎號排序
            sortedWinNums.Add(winNums[6]); //淺拷貝第二區獎號給sortedWinNums
            lbl開出順序A1.Text = $"{winNums[0], 3}{winNums[1], 5}{winNums[2], 5}{winNums[3], 5}{winNums[4], 5}{winNums[5], 5}";
            lbl開出順序A2.Text = $"{winNums[6], 2}";
            lbl大小順序A1.Text = $"{sortedWinNums[0], 3}{sortedWinNums[1], 5}{sortedWinNums[2], 5}{sortedWinNums[3], 5}{sortedWinNums[4], 5}{sortedWinNums[5], 5}";
            lbl大小順序A2.Text = $"{sortedWinNums[6], 2}";

            ResultPage resultPage = new ResultPage(); //結果頁面物件
            int totalPrice = 0; //獎金總計
            resultPage.lbl中獎明細.Text = "";


            //將選號紀錄逐筆比對開獎號碼
            for (int i = 0; i < listBox選號紀錄.Items.Count; i++)
            {
                int a1Win = 0; //第一區中獎數
                int a2Win = 0; //第二區中獎數

                for (int j = 0; j <= 5; j++)
                {
                    if (winNums.GetRange(0, 6).Contains(selectedNums[i][j]))
                    {
                        a1Win++;
                    }
                }
                if (winNums[6] == selectedNums[i][6])
                {
                    a2Win++;
                }

                if (a1Win == 1 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中普獎 NT$100!\n";
                    totalPrice += 100;
                }
                else if (a1Win == 3 && a2Win == 0)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中玖獎 NT$100!\n";
                    totalPrice += 100;
                }
                else if (a1Win == 2 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中捌獎 NT$200!\n";
                    totalPrice += 200;
                }
                else if (a1Win == 3 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中柒獎 NT$400!\n";
                    totalPrice += 400;
                }
                else if (a1Win == 4 && a2Win == 0)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中陸獎 NT$800!\n";
                    totalPrice += 800;
                }
                else if (a1Win == 4 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中伍獎 NT$4,000!\n";
                    totalPrice += 4000;
                }
                else if (a1Win == 5 && a2Win == 0)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中肆獎 NT$20,000!\n";
                    totalPrice += 20000;
                }
                else if (a1Win == 5 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中參獎 NT$150,000!\n";
                    totalPrice += 150000;
                }
                else if (a1Win == 6 && a2Win == 0)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中貳獎 NT$12,035,218!\n";
                    totalPrice += 12035218;
                }
                else if (a1Win == 6 && a2Win == 1)
                {
                    resultPage.lbl中獎明細.Text += $"{listBox選號紀錄.Items[i]} 中頭獎 NT$141,883,609!\n";
                    totalPrice += 141883609;
                }
            }
            //若沒中任何獎，則在結果頁面中的中獎名細顯示 "銘謝惠顧，無中獎記錄。"
            if (resultPage.lbl中獎明細.Text == "")
            {
                resultPage.lbl中獎明細.Text = "銘謝惠顧，無中獎記錄。";
            }

            //分別設值給消費總額與中獎總額顯示元件
            resultPage.lbl消費總額.Text = $"{totalCost}";
            resultPage.lbl中獎總額.Text = $"{totalPrice}";

            //開啟結果頁面
            resultPage.ShowDialog();

            //對完獎後進行初始設置
            totalCost = 0;
            listBox選號紀錄.Items.Clear();
            selectedNums.Clear();
            tempSelectedNums.Clear();
            lbl開出順序A1.Text = "未開獎";
            lbl開出順序A2.Text = "";
            lbl大小順序A1.Text = "未開獎";
            lbl大小順序A2.Text = "";
        }
    }
}