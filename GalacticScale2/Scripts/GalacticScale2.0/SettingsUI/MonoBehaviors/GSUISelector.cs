﻿using System;
using System.Collections.Generic;
using System.Linq;
using Steamworks;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace GalacticScale
{
    public class GSUISelector : MonoBehaviour
    {
        public Button lbutton;
        public Button rButton;
        public GSOptionCallback OnLeftClick;
        public GSOptionCallback OnRightClick;
        public GSOptionCallback OnChange;
        public Text _labelText;
        public Text _hintText;
        public Text _itemText;
        public List<string> Items = new List<string>() {"Test", "Test2", "test3!"};
        private int _index = 0;
        public int index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
                UpdateItem();
            }
        }

        public string value
        {
            get
            {
                return Items[_index];
            }
            set
            {
                if (!Items.Contains(value)) GS2.Error($"Trying to set an invalid value of {value}");
                else _index = Items.IndexOf(value);
                UpdateItem();
            }
        }

        public void UpdateItem()
        {
            if (Items.Count == 0) return;
            if (_index < 0 || _index >= Items.Count) index = 0;
            _itemText.text = Items[_index];
        }
        public string Hint
        {
            get => _hintText.text;
            set => _hintText.text = value;
        }
        public string Label
        {
            get => _labelText.text;
            set => _labelText.text = value;
        }


        public void LeftClick()
        {
            Debug.Log("LeftClick");
            _index--;
            if (_index < 0) _index = Items.Count - 1;
            UpdateItem();
        }
        public void RightClick()
        {
            Debug.Log("LeftClick");
            _index--;
            if (_index > Items.Count -1) _index = 0;
            UpdateItem();
        }
        public void initialize(GSUI options)
        {
            // GS2.Log("Initializing");
            //_dropdown.AddOptions(options.Data as List<string>);
            // Caption = (string)options.Data;
            Canvas.ForceUpdateCanvases();
            Label = options.Label;
            Hint = options.Hint;
            OnChange = options.callback;
            //options.postfix?.Invoke();

        }
    }

}