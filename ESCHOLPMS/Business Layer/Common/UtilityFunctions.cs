using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Linq;

namespace ESCHOLPMS
{
    public class UtilityFunctions 
    {

        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }



        public static List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName.ToLower()).ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row => {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name.ToLower()))
                    {
                        try
                        {
                            pro.SetValue(objT, row[pro.Name]);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message);}
                    }
                }
                return objT;
            }).ToList();
        }


        public static void Success()
        {
            MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void Failed()
        {
            MessageBox.Show("Details Not Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void ConnectionFailed()
        {
            MessageBox.Show("Connection Failed To The Server. Network Releted Problem.", "Network Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        public static void DeleteSuccess()
        {
            MessageBox.Show("Deleted Successfully.","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void DeleteFailed()
        {
            MessageBox.Show("Deletion Failed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void Approved()
        {
            MessageBox.Show("Approved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void Reversed()
        {
            MessageBox.Show("Sucessfully Reversed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        public static void ImportData(object inputObject, DataSet ds)
        {

            if (ds.Tables[0].Rows.Count > 0)
            {
                System.Type inputType = inputObject.GetType();


                DataRow _dr = ds.Tables[0].Rows[0];

                foreach (DataColumn _dc in _dr.Table.Columns)
                {
                    if (inputType.GetProperty(_dc.ColumnName) != null)
                    {

                        PropertyInfo property = inputType.GetProperty(_dc.ColumnName);

                        if (_dr[_dc.ColumnName] != DBNull.Value)
                        {
                            property.SetValue(inputObject, _dr[_dc.ColumnName], null);
                        }
                    }
                }

            }
        }


        public static void ImportData(object inputObject, DataRow dr)
        {
            System.Type inputType = inputObject.GetType();

            foreach (DataColumn _dc in dr.Table.Columns)
            {
                if (inputType.GetProperty(_dc.ColumnName) != null)
                {
                    PropertyInfo property = inputType.GetProperty(_dc.ColumnName);
                    if (dr[_dc.ColumnName] != DBNull.Value)
                    {
                        property.SetValue(inputObject, dr[_dc.ColumnName], null);
                    }
                }
            }

        }


        
        public static void LoadCombo(Syncfusion.Windows.Forms.Tools.ComboBoxAdv ctl, DataTable dt, string itemDisplay, string itemValue, int i)
        {
           
            if (i == 1)
            {
                DataRow dr = dt.NewRow();
                dr[itemDisplay] = "--Select--";
                dr[itemValue] = 0;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }
            if (i == 2)
            {
                DataRow dr = dt.NewRow();
                dr[itemDisplay] = "--New--";
                dr[itemValue] = 0;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }
            ctl.DataSource = dt;
            ctl.DisplayMember = itemDisplay;
            ctl.ValueMember = itemValue;
            ctl.SelectedIndex = 0;
        }

        public static void LoadWindowsCombo(System.Windows.Forms.ComboBox ctl, DataTable dt, string itemDisplay, string itemValue, int i)
        {

            if (i == 1)
            {
                DataRow dr = dt.NewRow();
                dr[itemDisplay] = "--Select--";
                dr[itemValue] = 0;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }
            if (i == 2)
            {
                DataRow dr = dt.NewRow();
                dr[itemDisplay] = "--New--";
                dr[itemValue] = 0;
                dt.Rows.InsertAt(dr, 0);
                dt.AcceptChanges();
            }
            ctl.DataSource = dt;
            ctl.DisplayMember = itemDisplay;
            ctl.ValueMember = itemValue;
            ctl.SelectedIndex = 0;
        }

      



        public static void SuccessfullyUpdated()
        {
            MessageBox.Show("Successfully Saved/Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void SuccessfullyAdded()
        {
            MessageBox.Show("Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void ExportData(object inputObject, DataSet ds)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                System.Type inputType = inputObject.GetType();

                DataRow _dr = ds.Tables[0].Rows[0];

                foreach (DataColumn _dc in _dr.Table.Columns)
                {
                    if (inputType.GetProperty(_dc.ColumnName) != null)
                    {
                        PropertyInfo property = inputType.GetProperty(_dc.ColumnName);
                        if (_dr[_dc.ColumnName] != DBNull.Value)
                        {
                            property.SetValue(inputObject, _dr[_dc.ColumnName], null);
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Set the text box to allow enter only float numbers
        /// Set e.handled property in key press event of a textbox to this function
        /// </summary>
        /// <param name="txt">TextBox which has to be act as numeric textbox</param>
        /// <param name="_keyChar">keychar of the key pressed</param>
        /// <returns>bool (true - if key pressed is not number or . or backspace, false - if key pressed is  number or . or backspace </returns>
        /// <example>  e.Handled = CommonFunctions.NumericTextBox((TextBox)sender, e.KeyChar); </example>
        /// <remarks>Created On 31 Oct 2007, Created By Vinitha Vijayanath</remarks>
        public static bool NumericTextBox(TextBox txt, char _keyChar)
        {

            int _keyCode = _keyChar;

            if (char.IsNumber(_keyChar) || _keyChar.ToString() == "." || _keyCode == 8)
            {
                if (_keyChar.ToString() == ".")
                {
                    if (txt.Text.ToString().Trim().IndexOf(".") == -1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return true;
            }
        }

        public static void ExportData(object inputObject, DataRow dr)
        {
            System.Type inputType = inputObject.GetType();

            foreach (DataColumn _dc in dr.Table.Columns)
            {
                if (inputType.GetProperty(_dc.ColumnName) != null)
                {
                    PropertyInfo property = inputType.GetProperty(_dc.ColumnName);
                    if (dr[_dc.ColumnName] != DBNull.Value)
                    {
                        property.SetValue(inputObject, dr[_dc.ColumnName], null);
                    }
                }
            }

        }


        public static void PopulateTree(ref TreeView tvCntrl, DataTable dataSource, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            tvCntrl.Nodes.Clear();
            UtilityFunctions _objUtility = new UtilityFunctions();
            _objUtility.PopulateRootNodes(tvCntrl, dataSource, textField, valueField, parentLinkColumnName, rootNodeParentValue);
            tvCntrl.CollapseAll();
        }


        public void PopulateRootNodes(TreeView tvCntrl, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            //  Filter Root Nodes of the treee
            DataRow[] drTreeNodes;

            if (rootNodeParentValue.Trim().ToLower() == "null")
            {

                drTreeNodes = dtTree.Select(parentLinkColumnName + " is " + rootNodeParentValue);

            }
            else
            {
                drTreeNodes = dtTree.Select(parentLinkColumnName + " = " + rootNodeParentValue);

            }

            foreach (DataRow drTreeNode in drTreeNodes)
            {
                // TreeNode trNode = new TreeNode();
                TreeNode trNode = new TreeNode(drTreeNode[textField].ToString().Trim());
                trNode.Name = drTreeNode[valueField].ToString().Trim();
                //drTreeNode[textField], drTreeNode[valueField]
                tvCntrl.Nodes.Add(trNode);
                //Populate child nodes under the root node
                chilNodesExists = PopulateChildNodes(tvCntrl, trNode, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
            }
        }

        private bool PopulateChildNodes(TreeView tvCntrl, TreeNode trParent, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            string parentNodeID = trParent.Name;
            //  Filter Root Nodes of the treee
            DataRow[] drChildNodes = dtTree.Select(parentLinkColumnName + " = " + parentNodeID.ToString().Trim());
            if (drChildNodes.Length > 0)
            {
                foreach (DataRow drChildNode in drChildNodes)
                {
                    TreeNode trChild = new TreeNode(drChildNode[textField].ToString().Trim());
                    trChild.Name = drChildNode[valueField].ToString().Trim();
                    trParent.Nodes.Add(trChild);
                    //Populate child nodes under the root node
                    chilNodesExists = PopulateChildNodes(tvCntrl, trChild, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                }
                chilNodesExists = true;
            }
            else
            {
                chilNodesExists = false;
            }
            return chilNodesExists;

        }


        public static void PopulateTree(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dataSource, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            tvCntrl.Nodes.Clear();
            UtilityFunctions _objUtility = new UtilityFunctions();
            _objUtility.PopulateRootNodes(ref tvCntrl, dataSource, textField, valueField, parentLinkColumnName, rootNodeParentValue);
            tvCntrl.CollapseAll();

        }


        public void PopulateRootNodes(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            //  Filter Root Nodes of the treee
            DataRow[] drTreeNodes;
            if (rootNodeParentValue.Trim().ToLower() == "null")
            {

                drTreeNodes = dtTree.Select(parentLinkColumnName + " is " + rootNodeParentValue);

            }
            else
            {
                drTreeNodes = dtTree.Select(parentLinkColumnName + " = " + rootNodeParentValue);

            }
            foreach (DataRow drTreeNode in drTreeNodes)
            {
                // TreeNode trNode = new TreeNode();
                Syncfusion.Windows.Forms.Tools.TreeNodeAdv trNode = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drTreeNode[textField].ToString().Trim());
                trNode.HelpText = drTreeNode[valueField].ToString().Trim();
                //drTreeNode[textField], drTreeNode[valueField]
                tvCntrl.Nodes.Add(trNode);
                //Populate child nodes under the root node
                chilNodesExists = PopulateChildNodes(tvCntrl, trNode, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                //trNode.HelpText = "";
                trNode.ShowCheckBox = true;
                trNode.CheckState = CheckState.Unchecked;
                trNode.EnsureDefaultOptionedChild = true;
                trNode.Expanded = true;
                trNode.InteractiveCheckBox = true;
                trNode.Optioned = false;
            }
        }

        private bool PopulateChildNodes(Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, Syncfusion.Windows.Forms.Tools.TreeNodeAdv trParent, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            string parentNodeID = trParent.HelpText;
            //  Filter Root Nodes of the treee
            DataRow[] drChildNodes = dtTree.Select(parentLinkColumnName + " = " + parentNodeID.ToString().Trim());
            if (drChildNodes.Length > 0)
            {
                foreach (DataRow drChildNode in drChildNodes)
                {
                    Syncfusion.Windows.Forms.Tools.TreeNodeAdv trChild = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drChildNode[textField].ToString().Trim());
                    trChild.HelpText = drChildNode[valueField].ToString().Trim();
                    trParent.Nodes.Add(trChild);
                    //Populate child nodes under the root node
                    chilNodesExists = PopulateChildNodes(tvCntrl, trChild, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                    // trChild.HelpText = "";
                    trChild.ShowCheckBox = true;
                    trChild.CheckState = CheckState.Unchecked;
                    trChild.EnsureDefaultOptionedChild = true;
                    trChild.Expanded = false;
                    trChild.InteractiveCheckBox = false;
                    trChild.Optioned = false;
                }
                chilNodesExists = true;
            }
            else
            {
                chilNodesExists = false;
            }

            return chilNodesExists;

        }

        public string ReplaceSingQuote(string strText)
        {
            return strText.Replace("'", "''").Trim();
        }


        #region Populate Update Tree
        public static void PopulateUpdateTree(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dataSource, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            tvCntrl.Nodes.Clear();
            UtilityFunctions _objUtility = new UtilityFunctions();
            _objUtility.PopulateUpdateRootNodes(ref tvCntrl, dataSource, textField, valueField, parentLinkColumnName, rootNodeParentValue);
            tvCntrl.CollapseAll();

        }

        public void PopulateUpdateRootNodes(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            //  Filter Root Nodes of the treee
            DataRow[] drTreeNodes;
            if (rootNodeParentValue.Trim().ToLower() == "null")
            {

                drTreeNodes = dtTree.Select(parentLinkColumnName + " is " + rootNodeParentValue);

            }
            else
            {
                drTreeNodes = dtTree.Select(parentLinkColumnName + " = " + rootNodeParentValue);

            }
            foreach (DataRow drTreeNode in drTreeNodes)
            {
                // TreeNode trNode = new TreeNode();
           

                Syncfusion.Windows.Forms.Tools.TreeNodeAdv trNode = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drTreeNode[textField].ToString().Trim());
                trNode.HelpText = drTreeNode[valueField].ToString().Trim();
                //drTreeNode[textField], drTreeNode[valueField]
                tvCntrl.Nodes.Add(trNode);
                //Populate child nodes under the root node
                chilNodesExists = PopulateUpdateChildNodes(tvCntrl, trNode, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                //trNode.HelpText = "";
                trNode.ShowCheckBox = true;
                if (Convert.ToBoolean(drTreeNode["IsExists"]) == true)
                {
                    trNode.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    trNode.CheckState = CheckState.Unchecked;
                }

                trNode.EnsureDefaultOptionedChild = true;
                trNode.Expanded = true;
                trNode.InteractiveCheckBox = true;
                trNode.Optioned = false;
            }
        }

        private bool PopulateUpdateChildNodes(Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, Syncfusion.Windows.Forms.Tools.TreeNodeAdv trParent, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            string parentNodeID = trParent.HelpText;
            //  Filter Root Nodes of the treee
            DataRow[] drChildNodes = dtTree.Select(parentLinkColumnName + " = " + parentNodeID.ToString().Trim());
            if (drChildNodes.Length > 0)
            {
                foreach (DataRow drChildNode in drChildNodes)
                {
                    Syncfusion.Windows.Forms.Tools.TreeNodeAdv trChild = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drChildNode[textField].ToString().Trim());
                    trChild.HelpText = drChildNode[valueField].ToString().Trim();
                    trParent.Nodes.Add(trChild);
                    //Populate child nodes under the root node
                    chilNodesExists = PopulateUpdateChildNodes(tvCntrl, trChild, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                    // trChild.HelpText = "";
                    trChild.ShowCheckBox = true;
                    if (Convert.ToBoolean(drChildNode["IsExists"]) == true)
                    {
                        trChild.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        trChild.CheckState = CheckState.Unchecked;
                    }

                    trChild.EnsureDefaultOptionedChild = true;
                    trChild.Expanded = false;
                    trChild.InteractiveCheckBox = false;
                    trChild.Optioned = false;
                }
                chilNodesExists = true;
            }
            else
            {
                chilNodesExists = false;
            }

            return chilNodesExists;

        }

        #endregion

        #region PopulateSynchTree
        public static void PopulateSynTree(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dataSource, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            tvCntrl.Nodes.Clear();
            UtilityFunctions _objUtility = new UtilityFunctions();
            _objUtility.PopulateSynRootNodes(ref tvCntrl, dataSource, textField, valueField, parentLinkColumnName, rootNodeParentValue);
            tvCntrl.CollapseAll();

        }


        public void PopulateSynRootNodes(ref Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            //  Filter Root Nodes of the treee
            DataRow[] drTreeNodes;
            if (rootNodeParentValue.Trim().ToLower() == "null")
            {

                drTreeNodes = dtTree.Select(parentLinkColumnName + " is " + rootNodeParentValue);

            }
            else
            {
                drTreeNodes = dtTree.Select(parentLinkColumnName + " = " + rootNodeParentValue);

            }
            foreach (DataRow drTreeNode in drTreeNodes)
            {
                // TreeNode trNode = new TreeNode();
                Syncfusion.Windows.Forms.Tools.TreeNodeAdv trNode = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drTreeNode[textField].ToString().Trim());
                trNode.HelpText = drTreeNode[valueField].ToString().Trim();
                //drTreeNode[textField], drTreeNode[valueField]
                tvCntrl.Nodes.Add(trNode);
                //Populate child nodes under the root node
                chilNodesExists = PopulateSynChildNodes(tvCntrl, trNode, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                //trNode.HelpText = "";

            }
        }

        private bool PopulateSynChildNodes(Syncfusion.Windows.Forms.Tools.TreeViewAdv tvCntrl, Syncfusion.Windows.Forms.Tools.TreeNodeAdv trParent, DataTable dtTree, string textField, string valueField, string parentLinkColumnName, string rootNodeParentValue)
        {
            bool chilNodesExists = false;
            string parentNodeID = trParent.HelpText;
            //  Filter Root Nodes of the treee
            DataRow[] drChildNodes = dtTree.Select(parentLinkColumnName + " = " + parentNodeID.ToString().Trim());
            if (drChildNodes.Length > 0)
            {
                foreach (DataRow drChildNode in drChildNodes)
                {
                    Syncfusion.Windows.Forms.Tools.TreeNodeAdv trChild = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv(drChildNode[textField].ToString().Trim());
                    trChild.HelpText = drChildNode[valueField].ToString().Trim();
                    trParent.Nodes.Add(trChild);
                    //Populate child nodes under the root node
                    chilNodesExists = PopulateSynChildNodes(tvCntrl, trChild, dtTree, textField, valueField, parentLinkColumnName, rootNodeParentValue);
                    // trChild.HelpText = "";

                }
                chilNodesExists = true;
            }
            else
            {
                chilNodesExists = false;
            }

            return chilNodesExists;

        }

        #endregion


    }
}
