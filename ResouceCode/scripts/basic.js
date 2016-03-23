var current_element;

$(document).ready(function() {
	current_element = $('#s1');
	$('#clip-to-next').click(function() {
		$.scrollTo(current_element.next(), 500);
		current_element = current_element.next();
	});

	$('#clip-to-prev').click(function() {
		$.scrollTo(current_element.prev(), 500);
		current_element = current_element.prev();
	});

	$('#clip-to-top').click(function() {
		$.scrollTo(0, 1000);
		current_element = $('#s1');
	});
});
