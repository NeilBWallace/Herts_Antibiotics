using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace pharm_dbb
{
    public class crptesting : ContentPage
    {
        public crptesting()
        {
           StackLayout c  = new StackLayout
            {
                BackgroundColor=Color.White,
                Children = {
                    new Label { Text = "NICE published a guideline in December 2014 on the treatment of pneumonia in both the community and hospital settings. In primary care, the majority of patients without pneumonia present with symptoms of chest infection, and without access to chest X-ray it is sometimes difficult to determine if symptoms are caused by pneumonia or a lower respiratory tract infection of which the latter will resolve without antibiotic treatment. Antibiotics will benefit those patients who have a bacterial infection but will have no effect on those with a viral infection and may actually cause harm. " },
                    new Label { Text = "NICE are therefore recommending that in cases where patients present with symptoms of lower respiratory tract infection and pneumonia is not evident after clinical assessment, GPs should consider carrying out a CRP test if it is not clear whether antibiotics should be prescribed or not. The CRP test is an important tool that GPs can use and still be confident they are offering patients the best treatment whilst reducing their antibiotic prescribing. The results of the CRP test can be used to guide antibiotic prescribing as follows: " },
                    new Label { Text = "Do not routinely offer antibiotic treatment if the CRP concentration is less than 20mg/litre.Consider a delayed prescription if the CRP concentration is between 20mg / litre and 100mg / litre. Offer antibiotic therapy if the CRP concentration is greater than 100mg / litre.The full guideline can be found at the following link:  http://www.nice.org.uk/guidance/cg191.   " }  
                }
            };
            Content = new ScrollView
            {
                Content = c
            };
        }
    }
}
