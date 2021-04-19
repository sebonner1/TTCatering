function getAllReports()
{
    const allReportsAPIURL = "https://localhost:5000/api/reports";

    fetch(allReportsAPIURL, {
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        },
    }).then((response)=>{
        console.log(response);
    }).catch(function(error){
        console.log(error);
    })
}