
$("#toggler").click(function (event) {
    
    event.preventDefault();
    if ($.cookie('isClicked'))
    {
        $.cookie("isClicked", "")
        $("#sidebar-wrapper").stop().animate({ marginLeft: "-250px" }, 200);
       
    } else {
        $.cookie("isClicked", "true")
        $("#sidebar-wrapper").stop().animate({ marginLeft: "-420px" }, 200);
    }
    $(this).toggleClass("isClicked");
    return false;
});


$(function () {
if ($.cookie('isClicked')) {
    $("#sidebar-wrapper").stop().animate({ marginLeft: "-420px" }, 200);    
} else {  
    $("#sidebar-wrapper").stop().animate({ marginLeft: "-250px" }, 200);
}
})


