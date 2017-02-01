using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{



    public class GetImage
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


        public GetImage(string name, string image, string description)
        {
            Name = name;
            Image = image;
            Description = description;

        }
    }

    public class area_page : ContentPage
    {
        private ListView _pharmacylist;
        private string _name;
        private string _description;

        public void refresh()
        {
         }

        public void NextClick(object sender, EventArgs e)
        {
            var tg = new pharmacy( _name, _description);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        public area_page()
        {
            BackgroundColor = Color.FromHex("bdd1f6");
            var NextButton = new Button { WidthRequest = 100, Text = "Press for further Information" };
            NextButton.Clicked += NextClick;
      
            ////   List<GetImage> data = new List<GetImage>  {
            ////       new GetImage () {"Upper Respiratory",image="nose.png"},
            //     };

            var data = new List<GetImage>  {
                new GetImage("Upper Respiratory","nose.png","<a href='https://www.nice.org.uk/guidance/cg69'>  NICE - Self-limiting respiratory tract infections </a>"),
                 new GetImage("Lower Respiratory","lungs.png","LOWER RESPIRATORY TRACT INFECTIONS<p> Low doses of penicillins are more likely to select out resistance.<p> Do NOT use Quinolones first line due to poor pneumococcal activity. Reserve all Quinolones for proven resistant organisms.For people presenting with symptoms of LRTI and in whom after clinical assessment a diagnosis of pneumonia has not been made and it is not clear whether antibiotics should be prescribed, NICE have recommended that a point of care C - reactive protein test(CRP) be considered.<p> Do NOT routinely offer antibiotics if CRP < 20mg / litre, consider a delayed prescription if CRP is between 20mg / litre and 100mg / litre and offer antibiotic therapy if CRP is > 100mg / litre.<p> See individual pneumonia section at the beginning of the document for more details."),
                new GetImage("Urinary Tract","urinary.png","<p>URINARY TRACT<p> Nitrofurantoin is usually first line but is contraindicated if eGFR is < 45ml / minute / 1.73m <sup> 2 </sup> (but may be used for short courses of 3 to 7 days in patients with an eGFR of 30 - 44ml / minute). <p> Advice on when to perform a urine dipstick test can be found <a href = 'https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/345784/UTI_quick_ref_guidelines.pdf' > Guidance </a> "),
                new GetImage("Gastro Intestinal Tract","Gastro.png","Antibiotics are not recommended for adults with diarrhoea of unknown pathology. Evidence from 3 small randomised controlled trials (RCTs) suggests they have minimal benefits, there is a risk of serious adverse effects associated with their use and their use promotes the development of resistant bacteria. <p> Fluid replacement is essential and check travel, food, hospital and antibiotic history as C. difficile is increasing.<p> Please send stool specimens from suspected cases of food poisoning and post antibiotic use and notify Public Health England after seeking advice from a public health doctor if an outbreak is suspected.<p><a href = 'http://cks.nice.org.uk/gastroenteritis' > CKS - Gastroenteritis </ a >< p >< a href='http://cks.nice.org.uk/diarrhoea-prevention-and-advice-for-travellers'>    CKS – Travellers' diarrhoea prevention and advice</a>"),
                 new GetImage("Genital Tract","genital.png","GENITAL TRACT"),
                  new GetImage("Skin Infections","skin.png","SKIN INFECTIONS"),
                new GetImage("Viral Infections","virus.png","VIRAL INFECTIONS"),
                new GetImage("Dental Infections","Dental.png","DENTAL INFECTIONS"),
                new GetImage("Meningitis","meningitis.png","Meningitis"),
                //  new GetImage("Septecaemia","septicaemia.png","Septecaemia"),

      
              };
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);


            }

            Title = "Treatment Guidelines";
           Label t =new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Treatment Guidelines", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };

            //var pharm = _database.GetAreas();
            var pharm = data;

            _pharmacylist = new ListView
            {
                BackgroundColor = Color.FromHex("bdd1f6"),

                SeparatorColor = Color.FromHex("#ddd"),
            };

            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
            //  cell.SetValue(TextCell.TextProperty, );
            _pharmacylist.HeightRequest = 500;
            _pharmacylist.RowHeight = 65;

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;


            _pharmacylist.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (GetImage)e.SelectedItem;


                var tg = new pharmacy( user.Name, user.Description);
                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

                ((ListView)sender).SelectedItem = null; // de-select the row

            };


            var k = new StackLayout
            {
                BackgroundColor = Color.FromHex("bdd1f6"),
                // BackgroundColor =Color.White,
            };
            if (Device.OS == TargetPlatform.Windows)
            {
                k.Children.Add(t);

            }
            k.Children.Add(_pharmacylist);
            Content = k;
        }
    }
}
