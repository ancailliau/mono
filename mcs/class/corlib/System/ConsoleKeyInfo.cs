//
// System.ConsoleKeyInfo
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2005 Novell, Inc (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#if NET_2_0
namespace System {
	public struct ConsoleKeyInfo {
		ConsoleKey key;
		char keychar;
		ConsoleModifiers modifiers;

		public ConsoleKeyInfo (char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			this.key = key;
			this.keychar = keyChar;
			this.modifiers = (shift) ? ConsoleModifiers.Shift : 0;
			this.modifiers |= (alt) ? ConsoleModifiers.Alt : 0;
			this.modifiers |= (control) ? ConsoleModifiers.Control : 0;
		}

		public ConsoleKey Key {
			get { return key; }
		}

		public char KeyChar {
			get { return keychar; }
		}

		public ConsoleModifiers Modifiers {
			get { return modifiers; }
		}
	}
}
#endif

