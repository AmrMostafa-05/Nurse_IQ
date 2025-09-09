using Nurse_IQ.Enums.User;
using System.Reflection;

namespace Nurse_IQ.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string FullName => $"{Fname} {Lname}";
        public gender gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public role role { get; set; }
        public YearLevel ?Year_Level { get; set; } //can be null in case of 
        public string Educational_institution { get; set; }// when we get the data we make enum for it and put its values 
        public Type_of_Edu_inst Type_of_Educational_institution { get; set; }//colege or intstue
        public DateTime BirthDate { get; set; }
        List<String> interests_Fields { get; set; }


        public List<Course> Courses { get; set; }  // Student study course //Doctor teaches courses => we use eager loading so we 
                                                   // detect the role (Doctor or Student)
        public List<Lecture> Lectures { get; set; } 
        public List<UserRegisteredTraining> UserRegisteredTrainings { get; set; }
        public List<Quiz> quizes { get; set; }
        public List<Article> articles { get; set; }
        public List<Forumtopic> topics { get; set; }
        public List<MedicalTerm> medicalTerms { get; set; }
        public List<Medicine> medicines { get; set; }
        public List<Forumtopic> forumtopics { get; set; }
    }
}

/*🔹 Shared Relations Between User and Admin

Looking at both lists:

Appear in both User & Admin:

List<Course>

List<Lecture>

List<Quiz>

List<Article>

List<MedicalTerm>

List<Medicine>

List<Forumtopic>

👉 These are shared because:

A normal user (Student/Doctor) interacts with them (e.g., studies a course, takes quizzes, writes articles).

An admin manages them (creates/approves/deletes entries).

Exist only in Admin (management only):

List<Announcement>

List<Training>

List<training_video>

List<Offer>

List<ContactForm>

List<Diploma>

👉 These make sense as admin-only responsibilities, since students/doctors wouldn’t “own” them.

🔹 Summary

Shared relations (both User + Admin): Courses, Lectures, Quizes, Articles, MedicalTerms, Medicines, Forumtopics.

Admin-only relations: Announcements, Trainings, Training_videos, Offers, ContactForms, Diplomas.*/
/* admin can add these tables 
public List<Course> Courses { get; set; } // normal user has relation with it depends on the role  // and the role of admin to add or create  
public List<Lecture> Lectures { get; set; }// normal user has relation with it depends on the role  // and the role of admin to add or create  
public List<Quiz> Quizes { get; set; }// normal user has relation with it depends on the role  // and the role of admin to add or create  
public List<Announcement> Announcements { get; set; } 
public List<Training> Trainings { get; set; }
public List<training_video> training_videos { get; set; }
public List<Article> Articles { get; set; }
public List<Offer> Offers { get; set; }
public List<ContactForm> contactForms { get; set; }
public List<MedicalTerm> medicalTerms { get; set; }
public List<Medicine> medicines { get; set; }
public List<Forumtopic> forumtopics { get; set; }
public List<Diploma> diplomas { get; set; }
 */