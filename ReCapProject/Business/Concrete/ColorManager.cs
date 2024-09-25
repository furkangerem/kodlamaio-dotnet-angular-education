using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes.Errors;
using Core.Utilities.Results.Concretes.Success;
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

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_iColorDal.GetAll(), Messages.ColorListed);
        }

        public IDataResult<Color> GetColorById(int colorId)
        {
            return new SuccessDataResult<Color>(_iColorDal.Get(color => color.Id == colorId), Messages.ColorFound);
        }

        public IResult Add(Color color)
        {
            if (color.Name.Length <= 3)
                return new ErrorResult(Messages.ColorNameMissing);

            _iColorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            IDataResult<Color> tempColor = GetColorById(color.Id);
            if (tempColor.Data == null)
                return new ErrorResult(Messages.ColorNotExist);

            _iColorDal.Delete(tempColor.Data);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IResult Update(Color color)
        {
            IDataResult<Color> tempColor = GetColorById(color.Id);
            if (tempColor.Data == null)
                return new ErrorResult(Messages.ColorNotExist);

            tempColor.Data.Id = color.Id;
            tempColor.Data.Name = color.Name;
            _iColorDal.Update(tempColor.Data);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
