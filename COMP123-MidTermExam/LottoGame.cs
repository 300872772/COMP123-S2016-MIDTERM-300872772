using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Author: Md Mamunur Rahman 
 * Student ID: 300872772  
 * 
 * Date: June 24, 2016 
 * Description: This program demonstrates a game 'Console Lottery Number Picker'
 *  
 *  
 * Version: 0.0.1 -  . 
 */
namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {


        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private List<int> _numberList;
        private List<int> _elementList;
        private Random _random;
        private int _elementNumber;
        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /** 
         *   <summary> 
          * This is a public property for our private _elementList field 
          * </summary> 
          *  
          * @property {List<int>} ElementList 
          */

        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }

        }
        /** 
         *   <summary> 
          * This is a public property for our private _elementNumber field 
          * </summary> 
          *  
          * @property {int} ElementNumber 
          */
        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }
        /** 
         *   <summary> 
          * This is a public property for our private _numberList field 
          * </summary> 
          *  
          * @property {List<int>} NumberList 
          */

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

        }
        /** 
         *   <summary> 
          * This is a public property for our private_random field 
          * </summary> 
          *  
          * @property {Random} Random 
          */
        public Random Random
        {
            get
            {
               return this._random;
            }

        }
        /** 
       *   <summary> 
        * This is a public property for our private _setSize field 
        * </summary> 
        *  
        * @property {int} SetSize 
        */
        public int SetSize
        {
            get
            {
                return this._setSize;
            }

            set
            {
                this._setSize = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }


        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /** 
        * <summary> 
        * This method build the number set
        * </summary> 
        *  
        * @method _build 
        * @returns {void} 
        */

        private void _build()
        {
            for (int i = 0; i < this.SetSize; i++)
            {
                this.NumberList.Add(i);
            }
        }
        /** 
        * <summary> 
        * This method initialize values of properties
        * </summary> 
        *  
        * @method _initialize 
        * @returns {void} 
        */
        private void _initialize()
        {
            _elementList = new List<int>();
            _random = new Random();
            _numberList = new List<int>();
        }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }




        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /** 
          * <summary> 
          * This method pick elements
          * </summary> 
          *  
          * @method PickElements 
          * @returns {void} 
          */

        public void PickElements()
        {
            if (ElementList.Count>0)
            {

                this.NumberList.Clear();
                this.ElementList.Clear();
                this._build();
            }


            for (int i = 0; i < this.SetSize; i++)
            {

  
                int random = this.Random.Next(1, this.SetSize+1);

                this.ElementList.Add(this.NumberList[random]);
                this.NumberList.RemoveAt(random);


            }

            this.ElementList.Sort();
        }

    }
}
