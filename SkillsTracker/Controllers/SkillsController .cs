using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills/")]
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol><li>C#</li><li>Javascript</li><li>Python</li></ol>";
            return Content(html, "text/html");
        }
        [HttpGet]
        [Route("/skills/form/")]
        public IActionResult SkillsForm()
        {
            string form = "<form method='post' action='/skills/form/'>" +
                "<label>Date:</label><br>" +
                "<input type='date' name='date' /><br>" +
                "<label>C#:</label><br>" +
                "<select name='csharpLearningLevel'><option value='beginner'>Beginner</option><option value='intermediate'>Intermediate</option><option value='advanced'>Advanced</option></select><br>" +
                "<label>Javascript:</label><br>" +
                "<select name='javascriptLearningLevel'><option value='beginner'>Beginner</option><option value='intermediate'>Intermediate</option><option value='advanced'>Advanced</option></select><br>" +
                "<label>Python:</label><br>" +
                "<select name='pythonLearningLevel'><option value='beginner'>Beginner</option><option value='intermediate'>Intermediate</option><option value='advanced'>Advanced</option></select><br>" +
                "<input type='submit' value='Submit' />" +
                "</form>";
            return Content(form, "text/html");
        }
        [HttpPost]
        [Route("/skills/form/")]
        public IActionResult LearningLevelResults(string date, string csharpLearningLevel, string javascriptLearningLevel, string pythonLearningLevel)
        {
            return Content("<h1>" + date + "</h1>" + "<ol><li>C#: " + csharpLearningLevel + "</li><li>Javascript: " + javascriptLearningLevel + "</li><li>Python: " + pythonLearningLevel + "</li></ol>", "text /html");
        }
    }
}
