using DAL.Features.Commands;
using DAL.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using DataModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly IMediator _mediator;
        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {

            var allCustomer = await _mediator.Send(new GetAllCustomerQuery());
            return View(allCustomer);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer command)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    await _mediator.Send(new CreateCustomerCommand(command));
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(command);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var singleCustomerInfo = await _mediator.Send(new GetSingleCustomerQuery(id));

            return View(singleCustomerInfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _mediator.Send(new UpdateCustomerCommand(command));
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            
            return View();

        }

        public async Task<IActionResult> Details(int id)
        {
            var singleCustomerInfo = await _mediator.Send(new GetSingleCustomerQuery(id));

            return View(singleCustomerInfo);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var singleCustomerInfo = await _mediator.Send(new GetSingleCustomerQuery(id));
            await _mediator.Send(new DeleteCustomerCommand(singleCustomerInfo));

            return RedirectToAction(nameof(Index));
        }

    }
}
