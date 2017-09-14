using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControlLibrary.Controls
{

    [ToolboxData("<{0}:CustomCalender runat=server</{0}:CustomCalender>")]

    public class CustomCalender :CompositeControl
    {
        TextBox txtSelectedDate;
        ImageButton imgBtnCalender;
        Calendar calenderDate;
        [Category("Appearence")]
        [Description("Logo For The Button")]
        public string ImageUrl
        {
            get
            {
                EnsureChildControls();
                return imgBtnCalender.ImageUrl ?? string.Empty;
            }
            set
            {
                EnsureChildControls();
                imgBtnCalender.ImageUrl = value;
            }
        }
        protected override void CreateChildControls()
        {
            Controls.Clear();

            txtSelectedDate = new TextBox();
            txtSelectedDate.ID = "txtSelectedDate";
            txtSelectedDate.Width = Unit.Pixel(100);

            imgBtnCalender = new ImageButton();
            imgBtnCalender.ID = "imgBtnCalender";
            imgBtnCalender.ImageUrl = ImageUrl;
            imgBtnCalender.Width = Unit.Pixel(100);
            imgBtnCalender.Height = Unit.Pixel(100);

            calenderDate = new Calendar();
            calenderDate.ID = "calenderDate";

            this.Controls.Add(txtSelectedDate);
            this.Controls.Add(imgBtnCalender);
            this.Controls.Add(calenderDate);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            txtSelectedDate.RenderControl(writer);
            imgBtnCalender.RenderControl(writer);
            calenderDate.RenderControl(writer);
        }
    }
}
