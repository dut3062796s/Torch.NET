// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy;
using Numpy.Models;

namespace Torch
{
    public static partial class torch {
        public static partial class nn {
            /// <summary>
            ///	Applies Group Normalization over a mini-batch of inputs as described in
            ///	the paper Group Normalization .
            ///	
            ///	\[y = \frac{x - \mathrm{E}[x]}{ \sqrt{\mathrm{Var}[x] + \epsilon}} * \gamma + \beta
            ///	
            ///	\]
            ///	
            ///	The input channels are separated into num_groups groups, each containing
            ///	num_channels / num_groups channels.<br></br>
            ///	 The mean and standard-deviation are calculated
            ///	separately over the each group.<br></br>
            ///	 \(\gamma\) and \(\beta\) are learnable
            ///	per-channel affine transform parameter vectors of size num_channels if
            ///	affine is True.<br></br>
            ///	
            ///	This layer uses statistics computed from input data in both training and
            ///	evaluation modes.
            /// </summary>
            public partial class GroupNorm : Module
            {
                // auto-generated class
                
                public GroupNorm(PyObject pyobj) : base(pyobj) { }
                
                public GroupNorm(Module other) : base(other.PyObject as PyObject) { }
                
                public GroupNorm(int num_groups, int num_channels, double eps = 1.0e-5, bool affine = true)
                {
                    //auto-generated code, do not change
                    var nn = self.GetAttr("nn");
                    var __self__=nn;
                    var pyargs=ToTuple(new object[]
                    {
                        num_groups,
                        num_channels,
                    });
                    var kwargs=new PyDict();
                    if (eps!=1.0e-5) kwargs["eps"]=ToPython(eps);
                    if (affine!=true) kwargs["affine"]=ToPython(affine);
                    dynamic py = __self__.InvokeMethod("GroupNorm", pyargs, kwargs);
                    self=py as PyObject;
                }
                
            }
        }
    }
    
}
