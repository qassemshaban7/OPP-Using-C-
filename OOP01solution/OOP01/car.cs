using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace routeOOP01
{
    internal class car
    {
		#region attributes
		private int id;
		private string model;
		private double currentSpeed;
		#endregion
		#region properties
		public double CurrentSpeed
		{
			get { return currentSpeed; }
			set { currentSpeed = value; }
		}
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
        #endregion

		public car(int _id ,string _model,int _currentSpeed)
		{
			this.id = _id;
			this.model = _model;
			this.currentSpeed = _currentSpeed;
		} 
		public car(int _id , string _model)
		{
			id =_id ; 
			model = _model;
			currentSpeed = 120;
		}
        public car(int _id )
        {
            id = _id;
			model = "honda";
			currentSpeed = 100;
        }
        public override string ToString()
        {
			return $"{id}  :: {model} :: {currentSpeed}";
        }
	    
    } 
	
}
