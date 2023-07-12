using Ex_Gateau_Repository_Pattern.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ex_Gateau_Repository_Pattern.Controllers
{

    public class GateauController : Controller
    {
        /***************************************************************************/
     
        private readonly IGateauRepository _gateauRepository;
        private readonly IIngredientsRepository _ingredientsRepository;

        public GateauController(IGateauRepository gateauRepository, IIngredientsRepository ingredientsRepository)
        {
            _gateauRepository = gateauRepository;
            _ingredientsRepository = ingredientsRepository;
        }


        /*************************************************************************/

        //Dans votre action Index du contrôleur GateauController, récupérez tous les gâteaux à partir du IGateauRepository 
        public IActionResult Index()
        {
            var gateaux = _gateauRepository.MesGateaux;

            if (gateaux != null)
            {
                return View("~/Views/Home/Index.cshtml", gateaux);
            }
            else
            {
                return View("Ecoeurer que ca marche pas"); // ou une autre logique de gestion si la liste est vide
            }
        }



        public IActionResult GetImage(string imageName)
        {
            var imagePath = $"~/img/{imageName}.jpg";
            return File(imagePath, "image/jpg");
        }

        public IActionResult Ingredients(int id)
        {
            var gateau = _gateauRepository.GetGateau(id);

            if (gateau == null)
            {
                return NotFound();
            }

            var ingredients = _ingredientsRepository.Ingredients;

            if (ingredients != null)
            {
                var gateauIngredients = ingredients.Where(i => i.GateauID == id);
                gateau.Ingredients = gateauIngredients.ToList();
            }

            return View(gateau);
        }

        [HttpPost]
        public IActionResult Create(Gateau gateau)
        {
            if (ModelState.IsValid)
            {
                _gateauRepository.AjouterGateau(gateau);
                return RedirectToAction("Index", "Gateau");
            }

            return View(gateau);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            // Obtenez le gâteau à supprimer à partir du repository
            var gateau = _gateauRepository.GetGateau(id);

            if (gateau == null)
            {
                return NotFound();
            }

            return View(gateau);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            // Supprimer le gâteau à l'aide du repository
            _gateauRepository.SupprimerGateau(id);

            // Rediriger vers l'action Index pour afficher la liste de gâteaux mise à jour
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Gateau gateau = _gateauRepository.GetGateau(id);
            if (gateau == null)
            {
                return NotFound();
            }

            return View(gateau);
        }

        [HttpPost]
        public IActionResult Edit(Gateau gateau)
        {
            if (ModelState.IsValid)
            {
                // Récupérer le gâteau existant à partir du repository
                var existingGateau = _gateauRepository.GetGateau(gateau.Id);

                if (existingGateau == null)
                {
                    return NotFound();
                }

                // Mettre à jour les propriétés du gâteau existant avec les nouvelles valeurs
                existingGateau.Nom = gateau.Nom;
                existingGateau.UrlImage = gateau.UrlImage;
                existingGateau.Description = gateau.Description;

   

                // Enregistrer les modifications dans votre source de données (par exemple, base de données)
                _gateauRepository.ModifierGateau(existingGateau);

                return RedirectToAction("Index");
            }

            return View(gateau);
        }






    }
}
