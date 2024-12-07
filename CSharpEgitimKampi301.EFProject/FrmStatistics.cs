using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.TblLocation.Count().ToString();
            #endregion

            #region Toplam Kapasite Sayısı
            lblCapacityTotal.Text = db.TblLocation.Sum(x => x.LocationCapacity).ToString();
            #endregion

            #region Toplam Rehber Sayısı
            lblGuideCount.Text = db.TblGuide.Count().ToString();
            #endregion


            #region Ortalama Kapasite Sayısı
            lblAvgCapacity.Text = db.TblLocation.Average(x => x.LocationCapacity)?.ToString("0.00");
            #endregion

            #region Lokasyon Tablosundaki Ortalama Fiyatı
            lblAvgLocationPrice.Text = db.TblLocation.Average(x => x.LocationPrice)?.ToString("0.00") + "₺";
            #endregion

            #region Lokasyonda Eklenen Son Ülkeyi Bulma

            int lastCountryName = db.TblLocation.Max(x => x.LocationId);

            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationId == lastCountryName).Select(y => y.LocationCountry).FirstOrDefault();

            #endregion

            #region Kapadokya Locakasyonun Kapasite Sayısını Getirme
            lblCapadocciaLocationCapacity.Text = db.TblLocation.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            #endregion

            #region Türkiye ortalama Tur Kapasitesi

            lblTurkiyeCapacityAvg.Text = db.TblLocation.Where(x => x.LocationCountry == "Türkiye").Average(y => y.LocationCapacity).ToString();

            #endregion

            #region En Yüksek Kapasiteli Tur Lokasyonu
            var maxCapacity = db.TblLocation.Max(x => x.LocationCapacity);

            lblMaxCapacityLocation.Text = db.TblLocation.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();

            #endregion

            #region En Pahalı Tur
            var maxPrice = db.TblLocation.Max(x => x.LocationPrice);

            lblMaxPriceLocation.Text = db.TblLocation.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();
            #endregion


            #region Ayşegül Çınarın Tur Sayısı
            var guideIdByNameAysegulCinar = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();

            lblAysegulCinarLocationCount.Text = db.TblLocation.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
            #endregion

        }
    }
}
