using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWorkForOthers
{
    public partial class Home : System.Web.UI.Page
    {
        static List<TeamMember> tmList = new List<TeamMember>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { LoadTM(); }
            refreshBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int LastId = tmList.Count();
            TeamMember tm = new TeamMember() { Id = LastId + 1, Name = txtNewTM.Text };
            tmList.Add(tm);
            refreshBind();
            txtNewTM.Text = "";
            lblmessage.Text = "Added Successfully!";
        }
        void LoadTM()
        {
            
            TeamMember tm1 = new TeamMember() { Id = 1, Name = "Ravi Pol" };
            TeamMember tm2 = new TeamMember() { Id = 2, Name = "Steve Sand" };
            TeamMember tm3 = new TeamMember() { Id = 3, Name = "John Peters" };
            TeamMember tm4 = new TeamMember() { Id = 4, Name = "Test Roger" };
            tmList.Add(tm1);
            tmList.Add(tm2);
            tmList.Add(tm3);
            tmList.Add(tm4);
        }
        void refreshBind()
        {
            lstTeamMembers.DataSource = tmList;
            lstTeamMembers.DataTextField = "Name";
            lstTeamMembers.DataValueField = "Id";
            lstTeamMembers.DataBind();
        }
    }
    public class TeamMember {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}