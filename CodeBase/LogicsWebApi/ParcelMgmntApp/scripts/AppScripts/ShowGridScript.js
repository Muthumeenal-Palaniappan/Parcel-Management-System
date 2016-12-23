//(function ($) {
//jQuery.noConflict();

jQuery(document).ready(function () {

    debugger;
    jQuery.support.cors = true;
    //jQuery.browser = {};
    //(function () {
    //    jQuery.browser.msie = false;
    //    jQuery.browser.version = 0;
    //    if (navigator.userAgent.match(/MSIE ([0-9]+)\./)) {
    //        jQuery.browser.msie = true;
    //        jQuery.browser.version = RegExp.$1;
    //    }
    //})();
    var api_url = "http://localhost:51732/api/UserDetail";
    
    jQuery("#gridMain").jqGrid({
         
        url: 'http://localhost:51732/api/UserDetail',
        datatype: 'json',
        mtype: 'GET',
        colNames: ['UserId','First Name','Last Name','Address','Email','Phone'],
        colModel: [
        {name: 'UserId', index: 'UserId', width: 40,hidden:true },
        { name: 'FirstName', index: 'FirstName', width: 70,sortable:true,editable:true },
        { name: 'LastName', index: 'LastName', width: 70,editable:true },
        { name: 'Address', index: 'Address', width: 70,editable:true },
        { name: 'Email', index: 'Email', width: 70,editable:true },
        { name: 'Phone', index: 'Phone', width: 70,editable:true }
        ],
        pager: jQuery('#pagernav'),
        rowNum: 10,
        rowList: [10, 20, 30, 40, 50],
        height: '100%',
        viewrecords: true,
        caption: 'User Detail List',
        autowidth: true,
        sortname: 'id',
        sortorder:'desc',
        jsonReader: {
            root: "rows",
            page: "page",
            total: "total",
            records: "records",
            repeatitems: true,
            id: "id", // from the controller returned value
            cell: "cell",
            search: "_search"
        }
      

    });


    function updateDialog(action) {
        return {
            url: api_url
            , closeAfterAdd: true
            , closeAfterEdit: true
            , afterShowForm: function (formId) { }
            , modal: true
            , onclickSubmit: function (params) {
                var list = $("#gridMain");
                var selectedRow = list.getGridParam("selrow");
                rowData = list.getRowData(selectedRow);
                params.url += rowData.Id;
                params.mtype = action;
            }
            , width: "500"
        };
    }


    jQuery("#gridMain").jqGrid('navGrid', '#pagernav',
          { add: true, edit: true, del: true },
          updateDialog('PUT'),
          updateDialog('POST'),
          updateDialog('DELETE')
  );


});