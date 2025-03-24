using BookLibrary.Application.DTOs.Members;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {
        private readonly IMemberService _memberService;
       

        public MembersController(IMemberService memberService)
        {
            _memberService = memberService;
           
        }

        [HttpGet]
        public async Task<ActionResult<List<MemberDto>>> GetAll()
        {
            var members = await _memberService.GetAllMembersAsync();
            return Ok(members);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDto>> GetById(int id)
        {
            var member = await _memberService.GetMemberByIdAsync(id);
            if (member == null) return NotFound();
            return Ok(member);  
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateMemberDto memberDto)
        {
            var createMember = await _memberService.AddMemberAsync(memberDto);
            return CreatedAtAction(nameof(GetById), new { id = createMember.Id}, createMember);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateMemberDto memberDto)
        {
            if (id != memberDto.Id) return BadRequest();
            await _memberService.UpdateMemberAsync(id, memberDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var member = await _memberService.GetMemberByIdAsync(id);
            if (member == null) return NotFound();
            await _memberService.DeleteMemberAsync(id);
            return NoContent();
        }
    }
}
