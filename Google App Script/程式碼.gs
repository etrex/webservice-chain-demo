function doGet(e) {
  var data = e.parameter || e;
  print(data);
  
  //寫入結束後傳回true
  return ContentService.createTextOutput(true);
}


function print(data){
  //將Sheet指定為"資料庫"試算表     SpreadSheet = 試算表
  var SpreadSheet = SpreadsheetApp.openById("1anrbjKHPQi6r9UyWJN2lfKCXrfnCIq_b_QY6s0nQiLw");

  //取得頁籤:"工作表1"              Sheet = 頁籤
  var Sheet = SpreadSheet.getSheetByName("工作表1");

  //取得有資料的最後一行的"行數"(目的要在最後一行插入新資料)
  var LastRow = Sheet.getLastRow();
  
  //--開始寫入資料--  
  //在最後一行的下一行寫入資料
  var index = 1;
  for(var key in data){
    Sheet.getRange(LastRow+1, index).setValue(key);
    Sheet.getRange(LastRow+2, index).setValue(data[key]);
    index ++;
  }
}