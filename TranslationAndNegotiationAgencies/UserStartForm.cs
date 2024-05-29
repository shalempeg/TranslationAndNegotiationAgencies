using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationAndNegotiationAgencies
{
    public partial class UserStartForm : Form
    {
        private List<(string title, string content)> texts;
        private int currentIndex;
        public UserStartForm()
        {
            InitializeComponent();
            texts = new List<(string title, string content)>
            {
                ("О нас", "BTAN - бюро переводов и ведения переговоров предоставляет высококачественные услуги в области перевода и сопровождения международных переговоров. Мы объединяем профессионалов со всего мира, обеспечивая нашим клиентам точность, надежность и конфиденциальность. Наши специалисты обладают глубоким знанием языков и культур, что позволяет нам эффективно преодолевать языковые барьеры и содействовать успешному взаимодействию на международной арене."),
                ("Наши заслуги", "На протяжении более чем десяти лет BTAN успешно работает на рынке переводческих услуг. Мы гордимся нашими многочисленными достижениями, включая партнерство с крупными международными корпорациями и участие в масштабных международных проектах. Наши переводы публикуются в престижных изданиях, а наши переговорщики обеспечивают успех деловых встреч на высшем уровне."),
                ("Уровни знания языков", " BTAN мы уделяем особое внимание квалификации наших сотрудников. Все наши переводчики и переговорщики имеют подтвержденные уровни знания языков, начиная от B2 (Upper Intermediate) до C2 (Proficiency) согласно международной системе CEFR. Мы также предлагаем специализированные языковые курсы и тренинги для постоянного повышения квалификации наших специалистов."),
                ("Наша команда", "В BTAN работает команда высококвалифицированных специалистов, включающая переводчиков, редакторов, лингвистов и переговорщиков. Каждый член нашей команды обладает многолетним опытом работы и специализируется в различных областях, таких как юридический, медицинский, технический и бизнес-перевод. Мы гордимся нашим коллективом и всегда стремимся к профессиональному росту и развитию."),
            };
            currentIndex = 0;
            DisplayCurrentText();
        }
        private void DisplayCurrentText()
        {
            if (texts.Count > 0)
            {
                theme.Text = texts[currentIndex].title;
                info.Text = texts[currentIndex].content;
            }
        }

        private void nextinfo_Click(object sender, EventArgs e)
        {
            if (texts.Count > 0)
            {
                currentIndex = (currentIndex + 1) % texts.Count;
                DisplayCurrentText();
            }
        }

        private void backinfo_Click(object sender, EventArgs e)
        {
            if (texts.Count > 0)
            {
                currentIndex = (currentIndex - 1 + texts.Count) % texts.Count;
                DisplayCurrentText();
            }
        }

        private void record_Click(object sender, EventArgs e)
        {
            record recordBTAN = new record();
            recordBTAN.Show();
            this.Hide();
        }

        private void logoutaccount_Click(object sender, EventArgs e)
        {
            BTANauth exitBTAN = new BTANauth();
            exitBTAN.Show();
            this.Hide();
        }
    }
}
