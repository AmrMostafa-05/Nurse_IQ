using Microsoft.AspNetCore.Identity;
using Nurse_IQ.Enums.User;
using System.Reflection;

namespace Nurse_IQ.Models
{
    public class applicationUser:IdentityUser<int>
    {
        // id email and password and phone exists in the base class 
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string FullName { get; private set; }//configurated as computed 
        public gender gender { get; set; }
        public role role { get; set; }
        public YearLevel ?Year_Level { get; set; } //can be null in case of 
        public string Educational_institution { get; set; }// when we get the data we make enum for it and put its values 
        public Type_of_Edu_inst Type_of_Educational_institution { get; set; }//colege or intstue
        public DateTime BirthDate { get; set; }
        public List<String>? interests_Fields { get; set; }


        public List<Course> Courses { get; set; }  // Student study course //Doctor teaches courses => we use eager loading so we 
                                                   // detect the role (Doctor or Student)
        public List<Lecture> Lectures { get; set; } 
        public List<UserRegisteredTraining> UserRegisteredTrainings { get; set; }
        public List<Quiz> quizes { get; set; }
        public List<Article> articles { get; set; }
        public List<MedicalTerm> medicalTerms { get; set; }
        public List<Medicine> medicines { get; set; }
        public List<Forumtopic> forumtopics { get; set; }
        //===============================
        public List<Announcement> Announcements { get; set; }
        public List<Training> Trainings { get; set; }
        public List<training_video> TrainingVideos { get; set; }
        public List<Offer> Offers { get; set; }
        public List<ContactForm> ContactForms { get; set; }
        public List<Diploma> Diplomas { get; set; }
    }
}

/* Shared Relations Between User and Admin

List<Course>

List<Lecture>

List<Quiz>

List<Article>

List<MedicalTerm>

List<Medicine>

List<Forumtopic>
====================================
Exist only in Admin (management only):

List<Announcement>

List<Training>

List<training_video>

List<Offer>

List<ContactForm>

List<Diploma>

/* admin can add these tables 
public List<Course> Courses { get; set; }  
public List<Lecture> Lectures { get; set; }
public List<Quiz> Quizes { get; set; } 
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