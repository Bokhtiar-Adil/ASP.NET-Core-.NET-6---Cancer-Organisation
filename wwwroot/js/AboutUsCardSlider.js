const branchData =
    [
        {
            Id: 01,
            Location: "Khulna",
            Address: "12/A, Kuet Road, Khulna",
            Contact1: "01234-567890",
            Contact2: "01234-567891",
            Email: "evergreenkhulna@gmail.com",
        },
        {
            Id: 02,
            Location: "Dhaka",
            Address: "92/A, Dhanmondi, Dhaka",
            Contact1: "01234-567980",
            Contact2: "01234-567981",
            Email: "evergreendhaka@gmail.com",
        },
        {
            Id: 03,
            Location: "Chittagong",
            Address: "13/B, Main road, Chittagong",
            Contact1: "01234-566690",
            Contact2: "01234-566691",
            Email: "evergreenchtng@gmail.com",
        },
        {
            Id: 05,
            Location: "Rajshahi",
            Address: "20/M, Station Road, Rajshahi",
            Contact1: "01234-567877",
            Contact2: "01234-567878",
            Email: "evergreenrjshi@gmail.com",
        },
        {
            Id: 06,
            Location: "Sylhet",
            Address: "33/7, Main Road, Sylhet",
            Contact1: "01234-567870",
            Contact2: "01234-567871",
            Email: "evergreensylhet@gmail.com",
        }
    ]

const branchHolderArticle = document.querySelector("branch-holder");

window.addEventListener("DOMContentLoaded", function () {
    diplayBranch(branchData);
});

function displayBranch(singleBranch) {
    let branchItems = singleBranch.map(function (item) {
        return `<div class="single-branch">
            <h4>${item.Location}</h4>
            <ul>
                <li>${item.Address}</li>
                <li>${item.Contact1}</li>
                <li>${item.Contact2}</li>
                <li>${item.Address}</li>
            </ul>
        </div>`
    });
    branchItems = branchItems.join("");
    branchHolderArticle.innerHTML = branchItems;
}

