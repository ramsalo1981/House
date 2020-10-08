using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Repository;
using Repository.Models;

namespace HousingQueueWebApp.Controllers
{
    public class ApartmentsController : Controller
    {
        // GET: Apartments
        public ActionResult Index()
        {
            List<Apartment> apartments = ApartmentRepository.GetApartments();
            return View(apartments);
        }

        // GET: Apartments/Details/5
        public ActionResult Details(string id)
        {
            ObjectId apartmentId = new ObjectId(id);
            Apartment apartment = ApartmentRepository.GetApartmentById(apartmentId);
            return View(apartment);
        }

        // GET: Apartments/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Apartments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Apartment apartment)
        {
            try
            {
                // TODO: Add insert logic here
                ApartmentRepository.SaveApartment(apartment);

                return RedirectToAction(nameof(Index));
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Apartments/Edit/5
        public ActionResult Edit(string id)
        {
            ObjectId apartmentId = new ObjectId(id);
            Apartment apartment = ApartmentRepository.GetApartmentById(apartmentId);
            return View(apartment);
        }

        // POST: Apartments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Apartment apartment)
        {
            try
            {
                // TODO: Add update logic here
                ObjectId apartmentId = new ObjectId(id);
                ApartmentRepository.UpdateApartment(apartmentId, apartment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Apartments/Delete/5
        public ActionResult Delete(string id)
        {
            ObjectId apartmentId = new ObjectId(id);
            Apartment apartment = ApartmentRepository.GetApartmentById(apartmentId);
            return View(apartment);
            
        }

        // POST: Apartments/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                ObjectId apartmentId = new ObjectId(id);
                ApartmentRepository.DeleteApartmentById(apartmentId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}