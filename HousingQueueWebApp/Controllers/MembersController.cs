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
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Index()
        {
            List<Member> members = MemberRepository.GetMembers();
            return View(members);
        }

        // GET: Members/Details/5
        public ActionResult Details(string id)
        {
            ObjectId memberId = new ObjectId(id);
            Member member = MemberRepository.GetMemberById(memberId);
            return View(member);
        }
        
        // GET: Members/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Members/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            try
            {
                // TODO: Add insert logic here
                // Validate member
                MemberRepository.SaveMember(member);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Members/Edit/5
        public ActionResult Edit(string id)
        {
            ObjectId memberId = new ObjectId(id);
            Member member= MemberRepository.GetMemberById((memberId));
            return View(member);
        }

        // POST: Members/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Member member)
        {
            try
            {
                // TODO: Add update logic here
                ObjectId memberId = new ObjectId(id);
                MemberRepository.UpdateMember(memberId, member);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Members/Delete/5
        public ActionResult Delete(string id)
        {
            ObjectId memberId = new ObjectId(id);
            Member member = MemberRepository.GetMemberById((memberId));
            return View(member);
            
        }

        // POST: Members/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(string id)
        {
            try
            {
                // TODO: Add delete logic here
                ObjectId memberId = new ObjectId(id);
                MemberRepository.DeleteMemberById(memberId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}