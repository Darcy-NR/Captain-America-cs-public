namespace CaptainAmerica.Models
{
    public class CoverLetter
    {

        public static string MakeCoverLetter(Role role, int aboutMeType)
        {
            string intro = $"<p>My name is BLANK BLANK, I'm looking for software roles and opportunities in {role.Location}. The {role.Position} role {role.Company} has vacant caught my eye and seems to be an excellent fit for me.</p>";
            string aboutMe;
            switch (aboutMeType)
            {
                default:
                    aboutMe = "<p>I'm an enthusiastic IT professional with a diverse skill set in data, software, and web development.</p>";
                    break;
                case 1:
                    //WebDev
                    aboutMe = "<p>I'm an enthusiastic IT professional with strong data, software and web development skills. I have built a number of full stack websites, and several applications using Java. I consider my grasp of front end technologies to be extensive, with direct experience in JavaScript, ASP.NET, PHP, React, Vue, and Laravel. \n\n Including webapps, a mock forum/social media site, and several APIs.</p>";
                    break;
                case 2:
                    //SoftwareDev
                    aboutMe = "<p>I'm an enthusiastic IT professional with strong data, software development skills. I have built a number of full stack applications, Java, Python, and C#. Building functions and algorithms to both specification, and also self designed expressions.</p>";
                    break;
                case 3:
                    //AutomationTester
                    aboutMe = "<p>I'm an enthusiastic IT professional with strong data, software testing skills. I have built a number of automated testing applications in Selenium using Java and Python. I consider my ability to navigate web-apps via the DOM to be extensive, and am comfortable automating many browsers for input and output.</p>";
                    break;
            }

            string strongestAsset = "<p>I consider my strongest asset my problem solving ability, I think of myself exceptionally skilled with noticing patterns, analyzing data, and using that to form the foundations of a proper solution or path forward.</p>";

            string contactDeets = "<p>A website version of my CV, my LinkedIn, and my web portfolio can be found below and on my resume.</p><p>Website CV: WEBSITE <br> Portfolio: PORTFOLIO <br> LinkedIn: LINKEDIN <br> Github: GITHUB</p>";

            string outro = "<p>The role sounds exciting and I would love an opportunity to chat further about it and my skills. Please feel free to contact me at any time at MOBILENUMBER, please feel free to leave a message if I don't answer immediately and I will get back to you as soon as I can.\r\n\r\nThank you, and I hope to hear from you!";
        
            return intro + aboutMe + strongestAsset + contactDeets + outro;
        }

    }
}
