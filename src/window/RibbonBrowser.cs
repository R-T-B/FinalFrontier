﻿using System;
using UnityEngine;
using System.Collections.Generic;

namespace Nereid
{
   namespace FinalFrontier
   {
      class RibbonBrowser : AbstractWindow
      {

         private Vector2 scrollPosition = Vector2.zero;

         public static int WIDTH = (int)Math.Round(555 * GameSettings.UI_SCALE);
         public static int HEIGHT = (int)Math.Round(600 * GameSettings.UI_SCALE);

         private String search = "";


         public RibbonBrowser()
            : base(Constants.WINDOW_ID_RIBBONBROWSER, "Ribbons")
         {


         }

         protected override void OnWindow(int id)
         {
            GUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Enable all", FFStyles.STYLE_BUTTON))
            {
               FinalFrontier.configuration.EnableAllRibbons();
            }

            GUILayout.FlexibleSpace(); // Button("Ribbons:", GUIStyles.STYLE_LABEL);
            if (GUILayout.Button("Close", FFStyles.STYLE_BUTTON))
            {
               SetVisible(false);
               // save configuration in case a ribbon was enabled/disabled
               FinalFrontier.configuration.Save();
            }
            GUILayout.EndHorizontal();
            GUILayout.BeginHorizontal();
            GUILayout.Label("Search:", FFStyles.STYLE_LABEL);
            search = GUILayout.TextField(search, FFStyles.STYLE_STRETCHEDTEXTFIELD);
            GUILayout.EndHorizontal();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, FFStyles.STYLE_SCROLLVIEW, GUILayout.Height(HEIGHT));
            GUILayout.BeginVertical();
            int ribbonsFound = 0;
            foreach (Ribbon ribbon in RibbonPool.Instance())
            {
               String name = ribbon.GetName();
               String description = ribbon.GetDescription();
               if (search == null || search.Trim().Length == 0 || name.ContainsIgnoringCase(search) || description.ContainsIgnoringCase(search))
               {
                  GUILayout.BeginHorizontal(FFStyles.STYLE_RIBBON_AREA);
                  bool enabled = ribbon.enabled;
                  if(GUILayout.Toggle(enabled, "" , FFStyles.STYLE_NARROW_TOGGLE)!=enabled)
                  {
                     FinalFrontier.configuration.SetRibbonState(ribbon.GetCode(), !enabled);
                  }
                  GUILayout.Label(ribbon.GetTexture(), FFStyles.STYLE_SINGLE_RIBBON);
                  GUILayout.Label(name + ": " + description, FFStyles.STYLE_RIBBON_DESCRIPTION);
                  GUILayout.EndHorizontal();
                  ribbonsFound++;
               }
            }
            // no ribbons match search criteria
            if(ribbonsFound == 0)
            {
               GUILayout.BeginHorizontal(FFStyles.STYLE_RIBBON_AREA);
               GUILayout.Label("NONE", FFStyles.STYLE_SINGLE_RIBBON);
               GUILayout.Label("no ribbons found", FFStyles.STYLE_RIBBON_DESCRIPTION);
               GUILayout.EndHorizontal();
            }
            GUILayout.EndVertical();
            GUILayout.EndScrollView();
            GUILayout.Label(RibbonPool.Instance().Count() + " ribbons in total (" + RibbonPool.Instance().GetCustomRibbons().Count + " custom ribbons)", FFStyles.STYLE_STRETCHEDLABEL);
           
            GUILayout.EndVertical();

            DragWindow();
         }

         public override int GetInitialWidth()
         {
            return WIDTH;
         }
      }
   }
}