[ApiController]
[Route("api/[controller]")]
public class ExperienceController : ControllerBase{
    public readonly PortfolioContext _context;

    public ExperienceController(PortfolioContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllExperience()
    {
        var experiences = await _context.Experiences.OrderByDescending(e => e.UpdateAt).ToListAsync();
        return Ok(experiences);
    }

    [HttpPost]
    public async Task<IActionResult> AddExperience([FromBody] Experience experience){
        experience.CreatedAt = DateTime.UtcNow;
        experience.CreatedAt = DateTime.UtcNow;
        _context.Experiences.Add(experience);
        await _context.SaveChangesAsync();
        return CreateAction(nameof(GetAllExperience), new {id= experience.Id}, experience);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateExperience(int id, [FromBody] Experience experience){
        var existing = await _context.Experiences.FindAsync(id);
        if(existing==null) return NotFound();

        existing.Title = experience.Title;
        existing.Company = experience.Company;
        existing.StartDate = experience.StartDate;
        existing.EndDate = experience.EndDate;
        existing.Description = experience.Description;
        existing.UpdateAt= DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return NoContent();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExperience(int id){
            var experience = await _context.Experiences.FindAsync(id);
            if(experience==null) return NotFound();

            _context.Experiences.Remove(experience);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}