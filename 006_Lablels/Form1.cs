using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_Lablels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDavinch_Click(object sender, EventArgs e)
        {
            lblArt.Text = "레오나르도 다빈치는 이탈리아의 예술가로 이탈리아를 대표하는 석학(polymath)이다. 그는 화가이자 조각가, 발명가, 건축가, 해부학자, 지리학자, 음악가 등 다양한 분야와 직업을 갖고 활동했다.";
            lblArtist.Text = "《모나리자》(영어: Mona Lisa)는 16세기 르네상스 시대에 레오나르도 다 빈치가 그린 초상화로, 현재 프랑스 파리 루브르 박물관에 전시되어 있다. \"모나\"(mona)는 유부녀 이름 앞에 붙이는 이탈리아어 경칭이고, \"리자\"(Lisa)는 초상화의 모델이 된 여인의 이름이다.";
        }

        private void btnRaffaello_Click(object sender, EventArgs e)
        {
            lblArt.Text = "《아테네 학당》(이탈리아어: Scuola di Atene)은 화가 라파엘로의 프레스코화로 1509 ~ 1511년에 바티칸 사도 궁전 내부의 방들 가운데 교황의 개인 서재인 서명의 방에 교황 율리오 2세를 위해 만들어졌다. ";
            lblArtist.Text = "라파엘로 산치오 다 우르비노는 르네상스 시대 이탈리아의 예술가·화가";
        }
    }
}
