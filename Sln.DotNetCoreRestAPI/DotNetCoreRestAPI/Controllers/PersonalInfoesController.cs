using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreRestAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonalInfoesController : ControllerBase
    {
        private readonly RepositoryContext _context;
        private readonly ILogger _logger;
        public PersonalInfoesController(RepositoryContext context, ILogger<PersonalInfoesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/PersonalInfoes
        [HttpGet]
        public IEnumerable<PersonalInfo> GetPersonalInfo()
        {
            _logger.LogInformation("Get All PersonalInfo called. Total: " + _context.PersonalInfo.Count());
            return _context.PersonalInfo;
        }

        // GET: api/PersonalInfoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonalInfo([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personalInfo = await _context.PersonalInfo.FindAsync(id);

            if (personalInfo == null)
            {
                return NotFound();
            }

            return Ok(personalInfo);
        }

        // PUT: api/PersonalInfoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalInfo([FromRoute] long id, [FromBody] PersonalInfo personalInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personalInfo.ID)
            {
                return BadRequest();
            }

            _context.Entry(personalInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PersonalInfoes
        [HttpPost]
        public async Task<IActionResult> PostPersonalInfo([FromBody] PersonalInfo personalInfo)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                _context.PersonalInfo.Add(personalInfo);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetPersonalInfo", new { id = personalInfo.ID }, personalInfo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE: api/PersonalInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalInfo([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personalInfo = await _context.PersonalInfo.FindAsync(id);
            if (personalInfo == null)
            {
                return NotFound();
            }

            _context.PersonalInfo.Remove(personalInfo);
            await _context.SaveChangesAsync();

            return Ok(personalInfo);
        }

        private bool PersonalInfoExists(long id)
        {
            return _context.PersonalInfo.Any(e => e.ID == id);
        }
    }
}