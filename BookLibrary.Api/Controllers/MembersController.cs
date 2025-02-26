using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMemberRepository _memberRepository;

        public MembersController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Member>>> GetAll()
        {
            var members = await _memberRepository.GetAllAsync();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetById(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if (member == null) return NotFound();
            return Ok(member);  
        }

        [HttpPost]
        public async Task<ActionResult> Create(Member member)
        {
            await _memberRepository.AddAsync(member);
            return CreatedAtAction(nameof(GetById), new { id = member.Id}, member);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Member member)
        {
            if (id != member.Id) return BadRequest();
            await _memberRepository.UpdateAsync(member);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            if (member == null) return NotFound();
            await _memberRepository.DeleteAsync(member);
            return NoContent();
        }
    }
}
