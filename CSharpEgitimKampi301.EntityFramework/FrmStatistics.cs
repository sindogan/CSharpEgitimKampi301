using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EntityFramework
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {

            lblLocationCount.Text = db.Location.Count().ToString();
            lblSumCapacity.Text = db.Location.Sum(x => x.LocationCapacity).ToString();
            lblGuide.Text = db.Guide.Count().ToString();
            lblAvgCapacity.Text = db.Location.Average(x => x.LocationCapacity).ToString();
            lblAvgTourPrice.Text = db.Location.Average(x => x.LocationPrice).ToString() + "TL";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();
            lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.LocationCountry == "Türkiye").Average(y => y.LocationCapacity).ToString();
            var romeGuideId = db.Location.Where(x => x.LocationCity == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName.Trim() + " " + y.GuideSurname.Trim()).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(x => x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();
            var MaxPrice = db.Location.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.Location.Where(x => x.LocationPrice == MaxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();
            var guideIdByNameAyseYilmaz = db.Guide.Where(x => x.GuideName == "Ayşe" && x.GuideSurname == "Yılmaz").Select(y => y.GuideId).FirstOrDefault();
            lblAyseYılmazTourCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAyseYilmaz).Count().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
