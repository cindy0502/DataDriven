using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestSurvay.Model;
using System.Data.SqlClient;
using TestSurvay.Controls;

namespace TestSurvay
{
    public partial class Survay : System.Web.UI.Page
    {
        //private static int currentQuestionId = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                Session.Clear();
            }*/

            Object userAnser = Session["UserAnswer"];
            if (userAnser != null)
            {
                Label1.Text = Session["UserAnswer"].ToString();
            }

            //trying to get the attribute from the session
            Stack<int> followupQuestion = (Stack<int>) Session["FOLLOWUP_ID_LIST"];
            if (followupQuestion == null)
            {
                followupQuestion = new Stack<int>();
                followupQuestion.Push(1);
                Session["FOLLOWUP_ID_LIST"] = followupQuestion;
            }
         
                int currentQuestionIdInSeeion = followupQuestion.Peek();
            
            
            //Session["CURRENT_QUESTION_ID"] = currentQuestionIdInSeeion;
            

            /*if (Session["CURRENT_QUESTION_ID"] != null)
            {
                currentQuestionIdInSeeion = (int)Session["CURRENT_QUESTION_ID"];
            }
            else {
                currentQuestionIdInSeeion = 1;
            }*/
           

          
            /*
            // Question text
            QuestionText.Text = "What is your name ?";

            // Question Element
            TextBox textBox = new TextBox();
            textBox.ID = "AnswerTxtBox";

            PlaceHolder1.Controls.Add(textBox);*/

            Question question = getNextQuestion(currentQuestionIdInSeeion);

          if (question != null)
          {
              QuestionText.Text = question.text;
              if (question.type.Equals("text"))
              {
                  // We gonna create text box question control

                  //TextBox textBox = new TextBox();
                  TextBoxUserControl textBox = (TextBoxUserControl)LoadControl("~/Controls/TextBoxUserControl.ascx");
                  textBox.ID = "AnswerTxtBox";
                  PlaceHolder1.Controls.Add(textBox);
                  Session["CURRENT_QUESTION_TYPE"] = textBox.ID;
              }
              else if (question.type.Equals("radio"))
              {
                  // We gonna create radio button question control
                  RadioButtonUserControl radioBtnQuestion = (RadioButtonUserControl)LoadControl("~/Controls/RadioButtonUserControl.ascx");
                  radioBtnQuestion.ID = "RadioButton";
                  //RadioButtonList radioBtnQuestion = new RadioButtonList();
                  Session["CURRENT_QUESTION_TYPE"] = radioBtnQuestion.ID;

                  List<QuestionOption> questionOptions = getQuestionOptions(currentQuestionIdInSeeion);

                  foreach(QuestionOption option in  questionOptions) {
                      ListItem newItem = new ListItem();
                      newItem.Text = option.text;
                      radioBtnQuestion.getControl().Items.Add(newItem);
                  }

                  PlaceHolder1.Controls.Add(radioBtnQuestion);
                  
              }
              else if (question.type.Equals("checkbox"))
              {
                  // We gonna create check box question control
                  CheckBoxUserControl checkBoxQuestion = (CheckBoxUserControl)LoadControl("~/Controls/CheckBoxUserControl.ascx");
                  checkBoxQuestion.ID = "CheckBoxButton";
                  Session["CURRENT_QUESTION_TYPE"] = checkBoxQuestion.ID;
                  //CheckBoxList checkBoxQuestion = new CheckBoxList();
                  List<QuestionOption> questionOptions = getQuestionOptions(currentQuestionIdInSeeion);

                  foreach (QuestionOption option in questionOptions)
                  {
                      ListItem newItem = new ListItem();
                      newItem.Value = option.id.ToString();
                      newItem.Text = option.text;
                      if (option.nextQId != null)
                      {
                          newItem.Attributes["nextQId"] = option.nextQId.ToString();
                      }
                      
                      checkBoxQuestion.getControl().Items.Add(newItem);
                  }

                  PlaceHolder1.Controls.Add(checkBoxQuestion);
              }
          }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Accesss the current question from PlaceHolder
            Control userControl = PlaceHolder1.FindControl(Session["CURRENT_QUESTION_TYPE"].ToString());
            
            Stack<int> followupQuestionList = (Stack<int>)Session["FOLLOWUP_ID_LIST"];

            int currentQuestionIdInSeeion = ((Stack<int>)Session["FOLLOWUP_ID_LIST"]).Pop();
    
            Question question = getNextQuestion(currentQuestionIdInSeeion);
            if (question.nextQId != null)
            {
                //followupQuestionList.Push((int)question.nextQId);
                insertNextQuestionId((int)question.nextQId,followupQuestionList);
            }
            ListOfQuestion.Add(currentQuestionIdInSeeion.ToString());
            if (userControl is TextBoxUserControl)
            {
                TextBoxUserControl textBoxcontr = (TextBoxUserControl)userControl;
                //Label1.Text = textBoxcontr.getControl().Text;
                Session["UserAnswer"] = textBoxcontr.getControl().Text;
                System.Diagnostics.Debug.WriteLine("Answer = " + textBoxcontr.getControl().Text);
            }
            else if (userControl is CheckBoxUserControl)
            {
                CheckBoxUserControl checkBoxcontr = (CheckBoxUserControl)userControl;
                string answerVar = "";
                foreach(ListItem item in checkBoxcontr.getControl().Items) {
                    if (item.Selected)
                    {
                        answerVar += item.Text + ",";

                        if (item.Attributes["nextQId"] != null)
                        {
                           // followupQuestionList.Push(int.Parse(item.Attributes["nextQId"]));
                            insertNextQuestionId((int.Parse(item.Attributes["nextQId"])), followupQuestionList);
                        }
                    }
                }

                Session["UserAnswer"] = answerVar;
            }
            else
            {
                RadioButtonUserControl radioBtnControl = (RadioButtonUserControl)userControl;
                string answerVar = "";
                foreach (ListItem item in radioBtnControl.getControl().Items)
                {
                    if (item.Selected)
                    {
                        answerVar += item.Value;
                        if (item.Attributes["nextQId"] != null)
                        {

                            insertNextQuestionId((int.Parse(item.Attributes["next_q_id"])), followupQuestionList);
                        }
                    }
                }
                Session["UserAnswer"] = answerVar;
                // Radio button
            }



            // 1. Identify which type of question is current question
            // 2. Access that question to get answer out from it
            // Label1.Text = "Test label";
            if (followupQuestionList.Count > 0)
            {
                Object userAnwser = Session["UserAnswer"];
                ListOfAnswer.Add(userAnwser.ToString());

                Session["CURRENT_QUESTION_ID"] = question.nextQId;
                Response.Redirect("Survay.aspx");
            }
            else
            {
                Object userAnwser = Session["UserAnswer"];
                ListOfAnswer.Add(userAnwser.ToString());

                Session["ListOfAnswer"] = ListOfAnswer;
                Response.Redirect("EndSurvey.aspx");
            }
            
        }

        private Question getNextQuestion(int currentQuestionId)
        {
            //currentQuestionId++;

            Question q = null;

            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net; Initial Catalog=DB_9AB8B7_D18DDA6011; User Id=DB_9AB8B7_D18DDA6011_admin;Password=2UwvrBNk"))
            {
                SqlCommand cmd = new SqlCommand("select * from Question where id =" + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    q = new Question();
                   q.text = rd["question_text"].ToString();
                   q.type = rd["q_type"].ToString();
                   q.nextQId = rd["next_q_id"] as int?;
                }
            }

            return q;


            // Read values from database and assign it to question.

            // Create Sql Connection
            //Create Sql command
            //Execute the command
            //Read values
            //assign to question



            /*if (currentQuestionId == 1)
            {
                Question q1 = new Question();
                q1.id = 1;
                q1.text = "What is your name ?";
                q1.type = "text";

                return q1;
            }
            else if (currentQuestionId == 2)
            {
                Question q2 = new Question();
                q2.id = 2;
                q2.text = "What is your gender ?";
                q2.type = "radio";

                return q2;
            }
            else if (currentQuestionId == 3)
            {
                Question q3 = new Question();
                q3.id = 3;
                q3.text = "What is your state ?";
                q3.type = "checkbox";

                return q3;
            }*/
            
           // return null;
        }
        public List<string> ListOfAnswer
        {
            get
            {
                if (HttpContext.Current.Session["ListOfAnswer"] == null)
                {
                    HttpContext.Current.Session["ListOfAnswer"] = new List<string>();
                }
                return HttpContext.Current.Session["ListOfAnswer"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["ListOfAnswer"] = value;
            }

        }
        public List<string> ListOfQuestion
        {
            get
            {
                if (HttpContext.Current.Session["ListOfQuestion"] == null)
                {
                    HttpContext.Current.Session["ListOfQuestion"] = new List<string>();
                }
                return HttpContext.Current.Session["ListOfQuestion"] as List<string>;
            }
            set
            {
                HttpContext.Current.Session["ListOfQuestion"] = value;
            }

        }
        private List<QuestionOption> getQuestionOptions(int currentQuestionId)
        {
            List<QuestionOption> options = new List<QuestionOption>();
            using (SqlConnection conn = new SqlConnection("Data Source=SQL5027.site4now.net;Initial Catalog=DB_9AB8B7_D18DDA6011;User Id=DB_9AB8B7_D18DDA6011_admin;Password=2UwvrBNk"))
            {
                SqlCommand cmd = new SqlCommand("select * from Question_Options where q_id =" + currentQuestionId, conn);
                conn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                QuestionOption op = null;

                while (rd.Read())
                {
                    op = new QuestionOption();
                    op.text = rd["option_text"].ToString();
                    options.Add(op);
                    op.nextQId = rd["next_q_id"] as int?;
                    op.id = (int)rd["id"];
                }
            }

            return options;

        }
        private void insertNextQuestionId(int nextQuestionId, Stack<int> followupList)
        {
            if (!followupList.Contains(nextQuestionId) )
            {
                followupList.Push(nextQuestionId);
            }
        } 
    }

}