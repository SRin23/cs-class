using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }while(result == DialogResult.Retry);
            //magic number : 뭔지 모르지만, 이 숫자를 넣으면 동작해 -> 그렇기에 조건절에서 숫자만 사용하는것 좋지 않다(어떠한 뜻을 내포하는지 모르기 때문)
            //변수 혹은 상수로 정의하여 조건절에 나타내기
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //새로 생성된 모달창이 닫히기 전까지는 부모 모달 창을 사용할 수 없다.
            CustomForm form = new CustomForm();
            //form.MdiParent = this; //모달창을 MDI로 사용이 불가하다.
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.MdiParent = this;
            form.Show();
        }

    }
}
