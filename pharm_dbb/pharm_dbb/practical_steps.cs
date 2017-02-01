using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
    public class practical_steps : ContentPage
    {
        public practical_steps()
        {

    
           var layout= new StackLayout
                {
               BackgroundColor=Color.White,
                    Children =
                    {
                      new Label { Text = "Principle 2" },
                      new Label { Font= Font.OfSize("Helvetica-Oblique", NamedSize.Default) ,Text ="\u2022" +"A person is not to be treated as unable to make a decision unless all practicable steps to help him to do so have been taken without success." },
                      new Label {Text="\u2022" +"Chapter 3 of the MCA code of practice is all about how people can be helped to make their own decision Link to chapter 3 MCA code https://www.gov.uk/government/uploads/system/uploads/attachment_data/file/497253/Mental-capacity-act-code-of-practice.pdf" },
                      new Label {Text="\u2022" +" You must try all practical means to enable a person to make their own decision before deciding that they lack capacity." },
                      new Label {Text="\u2022" +"Give the person information relevant to the particular decision including information about any available options. " },
                      new Label {Text="\u2022" +"Try to find the most effective way to communicate with the person (e.g. avoid jargon and complicated terms and abbreviations, use a sign or language interpreter, pictures, Easy Read guides. Sometimes the support of a familiar worker or family member may help) " },
                      new Label {Text ="\u2022" +"This principle requires you to support the person's own decision making rather than trying to influence them to make the decision you believe would be in their best interest." },
                      new Label {Text="\u2022" +"The focus is on enablement rather than protection " }
                   }
                };

            Content = new ScrollView { Content = layout };

        }
    } 
}
