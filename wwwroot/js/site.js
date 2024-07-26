// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $("#testTab").tabs();

    // accordion
    $('.collapse').collapse()
    // co op table
    $('#coopTable').DataTable();

    // employment table
    $('#employmentTable').DataTable();

    // Loop through each person
    $(".person").each(function (index) {
        // Get the dialog and opener within this person
        var dialog = $(this).find(".dialog");
        var opener = $(this).find(".opener");

        // Give them unique ids
        dialog.attr("id", "dialog" + index);
        opener.attr("id", "opener" + index);

        // Initialize the dialog
        dialog.dialog({
            autoOpen: false,
            show: {
                effect: "blind",
            },
            hide: {
                effect: "explode",
                duration: 1000
            }
        });

        // Set the click event for the opener
        opener.on("click", function () {
            dialog.dialog("open");
        });
    });
    $(function () {
        $(".course").each(function (index) {
            // Get the dialog and opener within this course
            var dialog = $(this).find(".dialog");
            var opener = $(this).find(".opener");

            // Give them unique ids
            dialog.attr("id", "dialog" + index);
            opener.attr("id", "opener" + index);

            // Initialize the dialog
            dialog.dialog({
                autoOpen: false,
                show: {
                    effect: "blind",
                    duration: 1000
                },
                hide: {
                    effect: "explode",
                    duration: 1000
                },
                open: function (event, ui) {
                    var courseId = opener.text(); // Assuming the opener's text is the course ID
                    $.get("/path/to/your/endpoint?courseId=" + courseId, function (data) {
                        // Update the dialog with the fetched course details
                        dialog.html("<p>" + data.Title + "</p><p>" + data.Description + "</p>");
                    });
                }
            });

            opener.on("click", function () {
                dialog.dialog("open");
            });
        });
    });
});


