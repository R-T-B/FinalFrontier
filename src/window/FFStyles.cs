﻿using System;
using UnityEngine;

namespace Nereid
{
   namespace FinalFrontier
   {

      static class FFStyles
      {
         private static readonly GUIStyle _STYLE_SINGLE_RIBBON = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_SINGLE_RIBBON
         {
                get
                {
                    _STYLE_SINGLE_RIBBON.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_SINGLE_RIBBON;
                }
            }

         private static readonly GUIStyle _STYLE_RIBBON = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_RIBBON
         {
                get
                {
                    _STYLE_RIBBON.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RIBBON;
                }
            }

         private static readonly GUIStyle _STYLE_WINDOW = new GUIStyle(HighLogic.Skin.window);
         public static GUIStyle STYLE_WINDOW
         {
                get
                {
                    _STYLE_WINDOW.fontSize = (int)Math.Round(HighLogic.Skin.window.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_WINDOW;
                }
            }

         private static readonly GUIStyle _STYLE_TOOLTIP = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_TOOLTIP
         {
                get
                {
                    _STYLE_TOOLTIP.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_TOOLTIP;
                }
            }

         private static readonly GUIStyle _STYLE_BG_TOOLTIP = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_BG_TOOLTIP
         {
                get
                {
                    _STYLE_BG_TOOLTIP.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_BG_TOOLTIP;
                }
            }

         private static readonly GUIStyle _STYLE_BUTTON = new GUIStyle(HighLogic.Skin.button);
         public static GUIStyle STYLE_BUTTON
         {
                get
                {
                    _STYLE_BUTTON.fontSize = (int)Math.Round(HighLogic.Skin.button.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_BUTTON;
                }
            }


         private static readonly GUIStyle _STYLE_NARROW_BUTTON = new GUIStyle(HighLogic.Skin.button);
         public static GUIStyle STYLE_NARROW_BUTTON
         {
                get
                {
                    _STYLE_NARROW_BUTTON.fontSize = (int)Math.Round(HighLogic.Skin.button.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_NARROW_BUTTON;
                }
            }

         private static readonly GUIStyle _STYLE_CLOSE_BUTTON = new GUIStyle(HighLogic.Skin.button);
         public static GUIStyle STYLE_CONTROL_BUTTON
         {
                get
                {
                    _STYLE_CLOSE_BUTTON.fontSize = (int)Math.Round(HighLogic.Skin.button.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_CLOSE_BUTTON;
                }
            }

         private static readonly GUIStyle _STYLE_TOGGLE = new GUIStyle(HighLogic.Skin.toggle);
         public static GUIStyle STYLE_TOGGLE
         {
                get
                {
                    _STYLE_TOGGLE.fontSize = (int)Math.Round(HighLogic.Skin.toggle.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_TOGGLE;
                }
            }

         private static readonly GUIStyle _STYLE_NARROW_TOGGLE = new GUIStyle(HighLogic.Skin.toggle);
         public static GUIStyle STYLE_NARROW_TOGGLE
         {
                get
                {
                    _STYLE_NARROW_TOGGLE.fontSize = (int)Math.Round(HighLogic.Skin.toggle.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_NARROW_TOGGLE;
                }
            }


         private static readonly GUIStyle _STYLE_TEXTAREA = new GUIStyle(HighLogic.Skin.textArea);
         public static GUIStyle STYLE_TEXTAREA
         {
                get
                {
                    _STYLE_TEXTAREA.fontSize = (int)Math.Round(HighLogic.Skin.textArea.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_TEXTAREA;
                }
            }

         private static readonly GUIStyle _STYLE_TEXTFIELD = new GUIStyle(HighLogic.Skin.textField);
         public static GUIStyle STYLE_TEXTFIELD
         {
                get
                {
                    _STYLE_TEXTFIELD.fontSize = (int)Math.Round(HighLogic.Skin.textField.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_TEXTFIELD;
                }
            }

         private static readonly GUIStyle _STYLE_STRETCHEDTEXTFIELD = new GUIStyle(HighLogic.Skin.textField);
         public static GUIStyle STYLE_STRETCHEDTEXTFIELD
         {
                get
                {
                    _STYLE_STRETCHEDTEXTFIELD.fontSize = (int)Math.Round(HighLogic.Skin.textField.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_STRETCHEDTEXTFIELD;
                }
            }

         private static readonly GUIStyle _STYLE_STRETCHEDLABEL = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_STRETCHEDLABEL
         {
                get
                {
                    _STYLE_STRETCHEDLABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_STRETCHEDLABEL;
                }
            }

         private static readonly GUIStyle _STYLE_RLABEL = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_RLABEL
         {
                get
                {
                    _STYLE_RLABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RLABEL;
                }
            }

         private static readonly GUIStyle _STYLE_LABEL_OFF5 = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_LABEL_OFF5
         {
                get
                {
                    _STYLE_LABEL_OFF5.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_LABEL_OFF5;
                }
            }

         private static readonly GUIStyle _STYLE_BUTTON_LABEL = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_BUTTON_LABEL
         {
                get
                {
                    _STYLE_BUTTON_LABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_BUTTON_LABEL;
                }
            }

         private static readonly GUIStyle _STYLE_TITLE_LABEL = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_TITLE_LABEL
         {
                get
                {
                    _STYLE_TITLE_LABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_TITLE_LABEL;
                }
            }

         private static readonly GUIStyle _STYLE_RIBBON_LABEL = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_RIBBON_LABEL
         {
                get
                {
                    _STYLE_RIBBON_LABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RIBBON_LABEL;
                }
            }
            private static readonly GUIStyle _STYLE_BOX = new GUIStyle(HighLogic.Skin.box);
            public static GUIStyle STYLE_BOX
            {
                get
                {
                    _STYLE_BOX.fontSize = (int)Math.Round(HighLogic.Skin.box.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_BOX;
                }
            }

            private static readonly GUIStyle _STYLE_RIBBON_OFF5 = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_RIBBON_OFF5
         {
                get
                {
                    _STYLE_RIBBON_OFF5.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RIBBON_OFF5;
                }
            }

         private static readonly GUIStyle _STYLE_RIBBON_DESCRIPTION = new GUIStyle(HighLogic.Skin.label);
         public static GUIStyle STYLE_RIBBON_DESCRIPTION
         {
                get
                {
                    _STYLE_RIBBON_DESCRIPTION.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RIBBON_DESCRIPTION;
                }
            }

            private static readonly GUIStyle _STYLE_LABEL = new GUIStyle(HighLogic.Skin.label);
            public static GUIStyle STYLE_LABEL
            {
                get 
                {
                    _STYLE_LABEL.fontSize = (int)Math.Round(HighLogic.Skin.label.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_LABEL; 
                }
            }


            private static readonly GUIStyle _STYLE_RIBBON_AREA = new GUIStyle(HighLogic.Skin.scrollView);
         public static GUIStyle STYLE_RIBBON_AREA
         {
                get
                {
                    _STYLE_RIBBON_AREA.fontSize = (int)Math.Round(HighLogic.Skin.scrollView.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_RIBBON_AREA;
                }
            }


         private static readonly GUIStyle _STYLE_SCROLLVIEW = new GUIStyle(HighLogic.Skin.scrollView);
         public static GUIStyle STYLE_SCROLLVIEW
         {
                get
                {
                    _STYLE_SCROLLVIEW.fontSize = (int)Math.Round(HighLogic.Skin.scrollView.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_SCROLLVIEW;
                }
            }

         private static readonly GUIStyle _STYLE_BUTTON_HOTYKEY = new GUIStyle(HighLogic.Skin.textField);
         public static GUIStyle STYLE_BUTTON_HOTYKEY
         {
                get
                {
                    _STYLE_BUTTON_HOTYKEY.fontSize = (int)Math.Round(HighLogic.Skin.textField.fontSize * GameSettings.UI_SCALE);
                    return _STYLE_BUTTON_HOTYKEY;
                }
            }
  
         static FFStyles()
         {
            STYLE_SINGLE_RIBBON.fixedWidth = 120 * GameSettings.UI_SCALE;
            STYLE_SINGLE_RIBBON.fixedHeight = 32 * GameSettings.UI_SCALE; ;
            STYLE_SINGLE_RIBBON.stretchWidth = false;
            STYLE_SINGLE_RIBBON.stretchHeight = false;
            STYLE_SINGLE_RIBBON.contentOffset = Vector2.zero;
            STYLE_SINGLE_RIBBON.border = new RectOffset(0, 0, 0, 0);
            STYLE_SINGLE_RIBBON.padding = new RectOffset(0, 0, 0, 0);
            STYLE_SINGLE_RIBBON.margin = new RectOffset(2, 2, 2, 2);
            STYLE_STRETCHEDLABEL.stretchWidth = true;
            STYLE_STRETCHEDLABEL.clipping = TextClipping.Clip;
            STYLE_RLABEL.stretchWidth = true;
            STYLE_RLABEL.clipping = TextClipping.Clip;
            STYLE_RLABEL.alignment = TextAnchor.MiddleRight;
            STYLE_NARROW_BUTTON.stretchHeight = false;
            STYLE_NARROW_BUTTON.fixedHeight = 16;
            STYLE_BUTTON_LABEL.stretchWidth = true;
            STYLE_BUTTON_LABEL.clipping = TextClipping.Clip;
            STYLE_BUTTON_LABEL.font = STYLE_BUTTON.font;
            STYLE_BUTTON_LABEL.normal.textColor = STYLE_BUTTON.normal.textColor;
            STYLE_TITLE_LABEL.stretchWidth = true;
            STYLE_TITLE_LABEL.clipping = TextClipping.Clip;
            STYLE_TITLE_LABEL.font = STYLE_BUTTON.font;
            STYLE_TITLE_LABEL.alignment = TextAnchor.LowerLeft;
            STYLE_TITLE_LABEL.normal.textColor = STYLE_BUTTON.normal.textColor;
            STYLE_RIBBON_LABEL.stretchWidth = true;
            STYLE_RIBBON_LABEL.stretchHeight = false;
            STYLE_RIBBON_LABEL.fixedHeight = Ribbon.HEIGHT/2;
            STYLE_RIBBON_LABEL.clipping = TextClipping.Clip;
            STYLE_RIBBON_LABEL.font = STYLE_BUTTON.font;
            STYLE_RIBBON_LABEL.alignment = TextAnchor.UpperLeft;
            STYLE_RIBBON_LABEL.border = new RectOffset(0, 0, 0, 8);
            STYLE_RIBBON_LABEL.margin = new RectOffset(10, 0, 0, 8);
            STYLE_RIBBON_LABEL.padding = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON_DESCRIPTION.stretchWidth = true;
            STYLE_RIBBON_DESCRIPTION.border = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON_DESCRIPTION.padding = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON_DESCRIPTION.margin = new RectOffset(3, 3, 3, 3);
            STYLE_RIBBON_DESCRIPTION.fontSize = 12;
            STYLE_RIBBON_AREA.fixedWidth = 505 * GameSettings.UI_SCALE; ;
            STYLE_RIBBON_AREA.fixedHeight = 42 * GameSettings.UI_SCALE; ;
            STYLE_RIBBON_AREA.padding = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON_AREA.clipping = TextClipping.Clip;
            STYLE_TOOLTIP.wordWrap = false;
            STYLE_TOOLTIP.alignment = TextAnchor.MiddleLeft;
            STYLE_TOOLTIP.stretchWidth = true;
            STYLE_TOOLTIP.normal.textColor = Color.white;
            STYLE_BG_TOOLTIP.wordWrap = false;
            STYLE_BG_TOOLTIP.alignment = TextAnchor.MiddleLeft;
            STYLE_BG_TOOLTIP.stretchWidth = true;
            STYLE_BG_TOOLTIP.normal.textColor = Color.black;
            STYLE_CONTROL_BUTTON.fixedWidth = 70 * GameSettings.UI_SCALE; ;
            STYLE_CONTROL_BUTTON.stretchWidth = false;
            STYLE_RIBBON.fixedWidth = 60 * GameSettings.UI_SCALE; ;
            STYLE_RIBBON.fixedHeight = 16 * GameSettings.UI_SCALE; ;
            STYLE_RIBBON.border = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON.margin = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON.padding = new RectOffset(0, 0, 0, 0);
            STYLE_TEXTAREA.stretchHeight = true;
            STYLE_NARROW_TOGGLE.border = new RectOffset(0, 0, 0, 0);
            STYLE_NARROW_TOGGLE.margin = new RectOffset(0, 0, 0, 0);
            STYLE_NARROW_TOGGLE.padding = new RectOffset(0, 0, 0, 0);
            STYLE_NARROW_TOGGLE.alignment = TextAnchor.UpperLeft;
            STYLE_RIBBON_OFF5.stretchWidth = false;
            STYLE_RIBBON_OFF5.stretchHeight = false;
            STYLE_RIBBON_OFF5.fixedHeight = Ribbon.HEIGHT / 2;
            STYLE_RIBBON_OFF5.fixedWidth = Ribbon.WIDTH / 2;
            STYLE_RIBBON_OFF5.clipping = TextClipping.Clip;
            STYLE_RIBBON_OFF5.alignment = TextAnchor.UpperLeft;
            STYLE_RIBBON_OFF5.border = new RectOffset(0, 0, 0, 0);
            STYLE_RIBBON_OFF5.margin = new RectOffset(5, 5, 5, 5);
            STYLE_RIBBON_OFF5.padding = new RectOffset(0, 0, 0, 0);
            STYLE_LABEL_OFF5.stretchWidth = true;
            STYLE_LABEL_OFF5.alignment = TextAnchor.MiddleLeft;
            STYLE_LABEL_OFF5.border = new RectOffset(0, 0, 0, 0);
            STYLE_LABEL_OFF5.margin = new RectOffset(5, 5, 5, 5);
            STYLE_LABEL_OFF5.padding = new RectOffset(0, 0, 0, 0);
            STYLE_SCROLLVIEW.alignment = TextAnchor.UpperLeft;
            STYLE_STRETCHEDTEXTFIELD.stretchWidth = true;
            STYLE_TOGGLE.margin = new RectOffset(0, 120, 0, 0);
            STYLE_BUTTON_HOTYKEY.padding = new RectOffset(0, 0, 0, 0);
            //STYLE_BUTTON_HOTYKEY.border = new RectOffset(0, 0, 18, 0);
            STYLE_BUTTON_HOTYKEY.fixedWidth = 80 * GameSettings.UI_SCALE; ;
            STYLE_BUTTON_HOTYKEY.alignment = TextAnchor.MiddleCenter;
            STYLE_BUTTON_HOTYKEY.stretchHeight = true;
            STYLE_BUTTON_HOTYKEY.stretchWidth = false;
         }
      }
   }
}