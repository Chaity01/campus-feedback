
var httpCount = new XMLHttpRequest();
var urlCount = 'http://localhost:8888/api/questions/studentcount/';
httpCount.open('GET', urlCount, true);

httpCount.onreadystatechange = function () {
    if (httpCount.status == 200) {
        var res = JSON.parse(httpCount.response);
        let studentcount = document.getElementById("studentcount");
        studentcount.innerHTML = res;
    }
}
httpCount.send();

var xValues = ["Poor", "Average", "Good", "Excellent"];
var barColors = [
  "#b91d47",
  "#00aba9",
  "#2b5797",
  "#e8c3b9"
];

var http = new XMLHttpRequest();
var url = 'http://localhost:8888/api/questions/';
http.open('GET', url, true);

http.setRequestHeader('Content-type', 'application/json;charset=utf-8');

http.onreadystatechange = function () {
    if (http.readyState == 4 && http.status == 200) {

        var res = JSON.parse(http.response);
        console.log(res);

        for (var i = 0; i < res.length; i++) {
            new Chart(JSON.stringify(res[i].questionId), {
                type: "pie",
                data: {
                    labels: xValues,
                    datasets: [{
                        backgroundColor: barColors,
                        data: [res[i].q1, res[i].q2, res[i].q3, res[i].q4]
                    }]
                }
            });
        }


    }
}
http.send();
