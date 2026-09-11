using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_2_PREFINAL_Karunungan_Eirene.Models;

namespace IT_ELECTIVE_2_PREFINAL_Karunungan_Eirene.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {

            return View(QuestionData.All.OrderBy(q => q.Number).ToList());


        }

        public IActionResult Details(int id)
        {
            var question = QuestionData.All.FirstOrDefault(q => q.Number == id);

            if (question == null)
            {


                return NotFound();
            }

            return View(question);

            //return View();
            //return NotFound;
        }

        public IActionResult AnswerSheet()
        {
            return View(QuestionData.All.OrderBy(q => q.Number).ToList());
        }
    }
}
