using Microsoft.AspNetCore.Mvc;
using WebApi.Domain;
using WebApi.Dto;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private static readonly List<Todo> _todos = new();

    /// <summary>
    /// возвращает все todo
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult Get()
    {
        // Анонимный тип
        var result = _todos
            .Select(t => new { t.Id, t.Title, plannedDay = t.PlannedDay.ToString("yyyy-MM-dd hh:mm:ss") }).ToList();

        return Ok(result);
    }

    /// <summary>
    /// Возвращает Todo по id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);

        if (todo == null)
            return NotFound();
        return Ok(todo);
    }

    /// <summary>
    /// Создает Dto
    /// </summary>
    /// <param name="createDto"></param>
    /// <returns></returns>
    [HttpPost]
    public IActionResult Create([FromBody] CreateTodoDto createDto)
    {
        int id = _todos.Count + 1;
        Todo todo = new(id, createDto.Title);

        _todos.Add(todo);

        return Ok();
    }

    /// <summary>
    /// удаляем по Todo по id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);

        if (todo == null)
            return NotFound();

        _todos.Remove(todo);

        return NoContent();
    }

    /// <summary>
    /// Изменяет Todo по id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="createTodoDto"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] CreateTodoDto createTodoDto)
    {
        var todo = _todos.FirstOrDefault(t => t.Id == id);

        if (todo == null)
            return NotFound();

        var newTodo = new Todo(todo.Id, createTodoDto.Title, DateTime.Now);

        _todos.Remove(todo);
        _todos.Add(newTodo);

        return Ok(newTodo);
    }

}