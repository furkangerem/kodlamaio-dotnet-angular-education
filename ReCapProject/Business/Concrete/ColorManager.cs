using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _iColorDal;
        public ColorManager(IColorDal iColorDal)
        {
            _iColorDal = iColorDal;
        }

        public List<Color> GetAll()
        {
            return _iColorDal.GetAll();
        }

        public Color GetColorById(int colorId)
        {
            return _iColorDal.Get(color => color.ColorId == colorId);
        }

        public void Add(Color color)
        {
            if (color.ColorName.Length <= 3)
                throw new Exception("The length of the color name must be at least 3 characters!");

            _iColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            Color tempColor = GetColorById(color.ColorId);
            if (tempColor == null)
                throw new Exception("You can not delete nonexisting color!");

            _iColorDal.Delete(tempColor);
        }

        public void Update(Color color)
        {
            Color tempColor = GetColorById(color.ColorId);
            if (tempColor == null)
                throw new Exception("You can not update nonexisting color!");

            tempColor.ColorId = color.ColorId;
            tempColor.ColorName = color.ColorName;
            _iColorDal.Update(tempColor);
        }
    }
}
