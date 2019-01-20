using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHomework
{
    public partial class Car
    {
        private static string _company;
        private static bool _isFourWheeled;

        private int _speed;
        private string _model;
        private string _color;
        private bool _isPassengerCar;

        static Car()
        {
            _company = "Mitsubishi";
            _isFourWheeled = true;
        }

        public Car()
        {
            _company = "Mitsubishi";
            _isFourWheeled = true;
        }

        public Car(int speed)
        {
            _speed = speed;
            _company = "Mitsubishi";
            _isFourWheeled = true;
        }

        public Car(bool isPassengerCar) {
            _isPassengerCar = isPassengerCar;
            _company = "Mitsubishi";
            _isFourWheeled = true;
        }

        public Car(string model, string color)
        {
            _model = model;
            _color = color;
            _company = "Mitsubishi";
            _isFourWheeled = true;
        }

        public Car(ref Car car)
        {
            _speed = car._speed;
            _model = car._model;
            _color = car._color;
            _isPassengerCar = car._isPassengerCar;
        }

        public int GetSpeed()
        {
            return _speed;
        }
        public string GetModel()
        {
            return _model;
        }
        public string GetColor()
        {
            return _color;
        }
        public bool IsPassengerCar()
        {
            return _isPassengerCar;
        }

        public void SetSpeed(int speed)
        {
            _speed = speed;
        }
        public void SetModel(string model)
        {
            _model = model;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public void SetIsPassengerCar(bool isPassengerCar)
        {
            _isPassengerCar = isPassengerCar;
        }
    }
}
