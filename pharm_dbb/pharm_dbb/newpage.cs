using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb


{

    
  
    public class newpage : ContentPage
    {
         private ListView _pharmacylist;
        private string name;

        public void refresh()
        {
     }
        public class page
        {
            public int id { set; get; }
            public string Title { set; get; }
            public string Description { set; get; }

        };
        public newpage(int i)
        {
            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);


            }
            //       _database = database;
            Title = "Antibiotics Guidelines";
            //   var pharm = _database.GetPage(i);
            //   var k= pharm.First();
            var Principles = "<li> This guidance is based on the best available evidence but professional judgement should always be used and patients should be involved in the decision making process.</li>";
            Principles = Principles + "<li> Choices of antibiotic are based on clinical evidence and not on cost as the aim is to reduce the incidence of healthcare associated infections.</li>";
            Principles = Principles + "<li> Antibiotics should be initiated as soon as possible in severe infection.</li>";
            Principles = Principles + "<li> Prescribing of antibiotics should only occur where consideration has been given to the origin of infection, there is a clinical need and the presence of viral infection such as sore throat, coughs and colds, viral conjunctivitis has been excluded.</li>";
            Principles = Principles + "<li><b> Antibiotics should not be prescribed during a telephone consultation apart from in exceptional circumstances.</b>";
              Principles = Principles + "<li> Consider the use of a delayed prescription for infections such as simple urinary tract infections, acute sore throat, acute cough, acute sinusitis, common cold.</li>";
                Principles = Principles + "<li> Where an antibiotic is indicated, the agent chosen should be the narrowest spectrum for the identified condition i.e.avoid broad spectrum antibiotics such as co - amoxiclav♣, cephalosporins♣ and quinolones♣.</li>";
                  Principles = Principles + "<li> Always prescribe for the shortest duration(using broad spectrum antibiotics for long periods can promote resistance). </li>";
               Principles = Principles + "<li> Always prescribe generically.</li>";
                   Principles = Principles + "<li> Avoid topical antibiotics unless indicated as they can promote resistance.</li>";
                    Principles = Principles + "<li> Always check for allergy before prescribing an antibiotic.</li>";
                    Principles = Principles + "<li><b> In pregnancy AVOID </b> prescribing tetracyclines, quinolones♣, and high dose metronidazole.If trimethoprim is prescribed in the first trimester, supplementation with folic acid 5mg is recommended and trimethoprim should not be prescribed to women who are folate deficient, taking a folate antagonist or have taken trimethoprim within the last year.Short term use of nitrofurantoin(avoid in 3rd trimester as there is a theoretical risk of neonatal haemolysis) is not expected to cause foetal problems.The manufacturer of clarithromycin advises against its use in pregnancy, particularly in the first trimester, unless the potential benefit outweighs the risk.</li>";
                    Principles = Principles + "<li> For recurrent or resistant infection, please contact your local microbiologist for advice. </li>";

                                                 var Restricted_Antibiotics = "<p> These antibiotics are significantly more likely to cause CDI and are therefore restricted. They are marked by the following symbol: ♣ and include cephalosporins♣, quinolones♣ and co-amoxiclav♣. ";
            Restricted_Antibiotics = Restricted_Antibiotics + "<p> Prescribers are reminded that recommendations to prescribe restricted antibiotics appear in the following areas only:";
            Restricted_Antibiotics = Restricted_Antibiotics + "<p><b> Cephalosporins♣:</b>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 1st line in epididymo - orchitis </li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 1st line in Pelvic inflammatory disease(PID) – high risk of gonorrhoea</li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in UTI in pregnancy </li>";
            Restricted_Antibiotics = Restricted_Antibiotics + " <li> 2nd line in Asymptomatic bacteriuria in pregnancy </li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "   <li> 2nd line acute pyelonephritis (pregnant) </li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "   <p><b> Quinolones♣:</b>";
            Restricted_Antibiotics = Restricted_Antibiotics + "       <li> 1st line in acute pyelonephritis</li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "  <li> 1st line in acute prostatitis</li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in Pelvic inflammatory disease(PID) </li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in diverticulitis </li>";
             Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in epididymo - orchitis </li>";
             Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in Helicobacter pylori eradication </li>";
         Restricted_Antibiotics = Restricted_Antibiotics + "<p><b> Co - amoxiclav♣:</b>";
       Restricted_Antibiotics = Restricted_Antibiotics + "<li> 1st line in diverticulitis </li>";
        Restricted_Antibiotics = Restricted_Antibiotics + "<li> 1st line in bites </li>";
         Restricted_Antibiotics = Restricted_Antibiotics + "<li> 1st line in “dirty” post op wound infection</li>";
          Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in acute pyelonephritis</li>";
           Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in acute sinusitis (persistent symptoms)</li>";
            Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in acute exacerbation of COPD (treatment failure)</li>";
              Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in UTI in children(upper UTI) </li>";
              Restricted_Antibiotics = Restricted_Antibiotics + "<li> 2nd line in cellulitis(facial) </li>";
            var title = "";
            var description = "";
            if (i == 1)
            {
                Title = "Restricted Antibiotics";
                title = "Restricted Antibiotics";
               description = Restricted_Antibiotics;
            };
            if (i == 2)
            {
                Title = "Principles of Treatment";
                title = "Principles of Treatment";
                description = Principles;
            };
            var browser =new WebView();
            var htmlSource = new HtmlWebViewSource();

            
                htmlSource.Html = "<div style='font-family:Helvetica;background-color:#1760ae;padding:5px;width=100%;color:white'>" + title + "</div>" + "<div style ='font-family:Helvetica;padding:5px;' > " + description+ "</div>";
            if (Device.OS == TargetPlatform.Windows)
            {
                htmlSource.Html = "<div style='font-size:20px;font-family:Helvetica;background-color:#1760ae;padding:5px;width=100%;color:white'>" + title + "</div>" + "<div style ='font-size:30px;font-family:Helvetica;padding:5px;' > " + description + "</div>";

            };
                browser.BackgroundColor = Color.Blue;
            browser.Source = htmlSource;          
            Content = browser;
       
 
        
        }
    }
}

