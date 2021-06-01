using ChromediaRestApiExam.DTOs;
using ChromediaRestApiExam.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChromediaRestApiExam.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ShapesController : ControllerBase
    {
        private static Square _square = new Square(2);
        private static Rectangle _rectangle = new Rectangle(2, 4);
        private static Triangle _triangle = new Triangle(2, 2, 2);

        [HttpGet("Square")]
        public ActionResult<Shape> GetSquare()
        {
            return _square;
        }

        [HttpPut("Square")]
        public ActionResult<Shape> PutSquare(SquareDTO dto)
        {
            _square.UpdateSize(dto.Size);
            return _square;
        }

        [HttpGet("Rectangle")]
        public ActionResult<Shape> GetRectangle()
        {
            return _rectangle;
        }

        [HttpPut("Rectangle")]
        public ActionResult<Shape> PutRectangle(RectangleDTO dto)
        {
            _rectangle.UpdateSize(dto.Width, dto.Height);
            return _rectangle;
        }

        [HttpGet("Triangle")]
        public ActionResult<Shape> GetTriangle()
        {
            return _triangle;
        }

        [HttpPut("Triangle")]
        public ActionResult<Shape> PutTriangle(TriangleDTO dto)
        {
            _triangle.UpdateSize(dto.Left, dto.Right, dto.Bottom);
            return _triangle;
        }
    }
}