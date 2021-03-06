﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE.md file or at
 * https://github.com/Wagnerp/Krypton-Toolkit-Suite-Extended-NET-5.460/blob/master/LICENSE
 *
 */
#endregion

using ComponentFactory.Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ExtendedControls.ExtendedToolkit.ToolstripControls
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)]
    [ToolboxBitmap(typeof(KryptonNumericUpDown))]
    public partial class KryptonNumericUpDownToolStripItem : ToolStripControlHost
    {
        #region Constructor
        public KryptonNumericUpDownToolStripItem() : base(new KryptonNumericUpDown())
        {

        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets KryptonNumericUpDownControl.
        /// </summary>
        /// <value>
        /// The base control.
        /// </value>
        public KryptonNumericUpDown KryptonNumericUpDownControl
        {
            get
            {
                return Control as KryptonNumericUpDown;
            }
        }

        /// <summary>
        /// Gets or sets Value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public decimal Value
        {
            get
            {
                return KryptonNumericUpDownControl.Value;
            }


            set
            {
                KryptonNumericUpDownControl.Value = value;
            }
        }
        #endregion
    }
}