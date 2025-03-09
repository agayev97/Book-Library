using AutoMapper;
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
        private readonly IMapper _mapper;

        public MembersController(IMemberService memberService, IMapper mapper)
        {
            _memberService = memberService;
            _mapper = mapper;
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
        public async Task<ActionResult> Create(MemberDto memberDto)
        {
            await _memberService.AddMemberAsync(memberDto);
            return CreatedAtAction(nameof(GetById), new { id = memberDto.Id}, memberDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, MemberDto memberDto)
        {
            if (id != memberDto.Id) return BadRequest();
            await _memberService.UpdateMemberAsync(memberDto);
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
