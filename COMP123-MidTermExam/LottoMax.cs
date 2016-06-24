using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }



        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {

            this.PickElements();

        }

    }
}