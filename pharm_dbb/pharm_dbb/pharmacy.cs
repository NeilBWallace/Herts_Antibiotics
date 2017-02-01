using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{

  
    public class pharmacy : ContentPage
    {
        private ListView _pharmacylist;
        private string name;
        private string _name;
        private string _description;
        public void refresh()
        {
        }
        public void NextClick(object sender, EventArgs e)
        {
            var tg = new pharmacy3(_name, _description);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg)));


        }

        public class Display
        {
            public string Infection { get; set; }

            public string Area { get; set; }

            public Display(string area,string infection)
            {
                Area = area;
                Infection = Infection;
            }

        }

        public pharmacy(string name, string description)
        {

            BackgroundColor = Color.FromHex("bdd1f6");

            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);


            }

            var data = new List<Pages>();
            if (name == "Upper Respiratory")
            {
                data.Add(new Pages
                {
                    Area = "Upper Respiratory",
                    Infection = "Otitis Externa (acute)",
                });
                data.Add(new Pages
                {
                    Area = "Upper Respiratory",
                    Infection = "Otitis media (acute)",
                });

                data.Add(new Pages
                {
                    Area = "Upper Respiratory",
                    Infection = "Pharyngitis / sore throat / tonsillitis",
                });
                data.Add(new Pages
                {
                    Area = "Upper Respiratory",
                    Infection = "Sinusitis (acute)",
                });


            }


            if (name == "Lower Respiratory")
            {
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "Community acquired pneumonia - treatment in the community",
                });
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "Acute exacerbation of COPD",
                });
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "Bronchiectasis (infective exacerbation of non CF patients)",
                });
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "Bronchitis (acute)",
                });
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "(HCT) Aspiration pneumonia ",
                });
                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "(HCT) Low Severity Community Acquired Pneumonia: Treatment in Hospital Setting",
                });



                data.Add(new Pages
                {
                    Area = "Lower Respiratory",
                    Infection = "(HCT) Moderate and High severity Community Acquired Pneumonia: Treatment in Hospital Setting",
                });






            }


            if (name == "Meningitis")
            {

                    data.Add(new Pages
                {
                    Area = "Meningitis",
                    Infection = "Suspected meningococcal disease",
                });

            }
            if (name == "Urinary Tract")
            {
                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "Asymptomatic bacteriuria in pregnancy (only treat when sensitivities are known)",
                });

                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "Pyelonephritis (acute)",
                });




                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI in women with haematuria and not pregnant (all ages from 14 years onwards) ",
                });
                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI in women with no visible haematuria, not pregnant or catheterised (all ages from 14 years onwards) ",
                });

                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI in pregnancy",
                });


                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI with catheter",
                });

                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI in men",
                });

                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI in children ( ≤ 16 years)",
                });

                data.Add(new Pages
                {
                    Area = "Urinary Tract",
                    Infection = "UTI - recurrent (≥ 3 per year) in non-pregnant women over 14 years",
                });


                data.Add(new Pages
                {
                    Area = "Urinary Tract Infection",
                    Infection = "(HCT) Urinary catheter insertion or change ",
                });



            }

            if (name == "Gastro Intestinal Tract")
            {



                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "Gastro-enteritis",
                });

                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "Clostridium difficile Infection (CDI)",
                });
                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "CDI recurrence",
                });

                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "Helicobacter pylori eradication (positive test)",
                });

                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "Threadworm",
                });
                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "(HCT) Clostridium difficile infection (CDI)",
                });

                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "(HCT) CDI recurrence",
                });
                data.Add(new Pages
                {
                    Area = "Gastro Intestinal Tract",
                    Infection = "Diverticulitis (acute)",
                });
            }
            if (name == "Genital Tract")
            {



                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Vaginal candidiasis",
                });

                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Vaginal candidiasis in pregnancy",
                });

                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Bacterial vaginosis",
                });

                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Chlamydia trachomatis",
                });


                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Epididymo-orchitis",
                });

                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Trichomonas vaginalis",
                });

                data.Add(new Pages
                {
                    Area = "Genital Tract",
                    Infection = "Pelvic Inflammatory Disease (PID)",
                });
            }

            if (name == "Skin Infections")
            {
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Acne (moderate or severe)",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Bites (animal and human)",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Bites (insect)",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Boils",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Cellulitis - mild or moderate",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Conjunctivitis",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Dermatophyte finger or toe nail infection",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Dermatophyte skin infection",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Eczema",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Impetigo",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Leg Ulcers",
                });


                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Mastitis",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Pilonidal sinus disease (discharging)",
                });


                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Post-operative wound infection",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "PVL",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "Scabies",
                });



                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Acne (moderate or severe)",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Cellulitis - mild",
                });

                data.Add(new Pages
                {
                    Area = "Skin infections",
                    Infection = "(HCT) Cellulitis - Moderate or severe",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Cellulitis - In Home First OPAT service within Lower Lea Valley only",
                });


                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Diabetic foot",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT)(class 1) Cellulitis related to leg ulcers/ lymphedema ",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT)(class 11/111) Cellulitis related to leg ulcers / lymphedema ",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) (Class IV)  Cellulitis related to leg ulcers /  lymphedema",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Recurrent cellulits related to leg ulcers / lymphodema",
                });

                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Dirty penetrating wound",
                });

                data.Add(new Pages
                {
                    Area = "Skin infections",
                    Infection = "(HCT) Acute osteomylelitis",
                });
                data.Add(new Pages
                {
                    Area = "Skin Infections",
                    Infection = "(HCT) Septic athritis",
                });

                data.Add(new Pages
                {
                    Area = "Septicaemia",
                    Infection = "(HCT) Septicaemia",
                });


            }

            if (name == "Viral Infections")
            {


                data.Add(new Pages
                {
                    Area = "Viral Infections",
                    Infection = "Chicken Pox",
                });


                data.Add(new Pages
                {
                    Area = "Viral Infections",
                    Infection = "Herpes Simplex (oral)",
                });
                data.Add(new Pages
                {
                    Area = "Viral Infections",
                    Infection = "Shingles",
                });
            }

            if (name == "Dental Infections")
            {
                data.Add(new Pages
                {
                    Area = "Dental Infections",
                    Infection = "(HCT Dental Services)",
                });


                data.Add(new Pages
                {
                    Area = "Dental Infections",
                    Infection = "Dental Abscess",
                });
            }
























         //   NavigationPage.SetHasNavigationBar(this, false);

            _description = description;
            _name = name;
            Title = name;
            //    var pharm = _database.GetItems(name);
            Label l = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = name, TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };




            var NextButton = new Button { BackgroundColor = Color.FromHex("1760ae"), Image = "info.png", Text = name, TextColor = Color.White, HeightRequest = 50, WidthRequest = 50 };
            NextButton.Clicked += NextClick;

            _pharmacylist = new ListView
            {
                BackgroundColor = Color.FromHex("bdd1f6"),
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                //SeparatorColor = Color.FromHex("#ddd"),
                SeparatorColor = Color.FromHex("#ddd"),

            };
            var items = new List<string>();


            _pharmacylist = new ListView
            {
                BackgroundColor = Color.FromHex("bdd1f6"),

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.RowHeight = 40;
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
            //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Infection");
            //    cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;

            //  cell.SetBinding(TextCell.TextProperty, "Infection");
            _pharmacylist.ItemTemplate = cell;





            _pharmacylist.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem == null) return;
                var user = (Pages)e.SelectedItem;
                //  var u = user.ToString();
                //  var user = e.SelectedItem.ToString();
                var tg = new comments(user.Infection);
                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row
            };



            var k = new StackLayout
            {


                Padding = new Thickness(10, 10, 10, 10),
                //    BackgroundColor = Color.White,
                BackgroundColor = Color.FromHex("bdd1f6"),
                Children = {
                  NextButton,
                  _pharmacylist

              }
            };


            var i = new StackLayout();

          
            i.Children.Add(k);
            Content = new ScrollView { Content = i };
        }
    }
}






