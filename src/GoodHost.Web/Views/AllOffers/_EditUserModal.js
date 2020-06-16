(function ($) {

    var address = ["New York", "Sarajevo", "Moskva"]
    var rooms = [3, 5, 4]
    var maxNumbrOfGuests = [3, 6, 5]
    var description = ["Lorem Ipsum", "Lorem Ipsum", "Nice destination"]

    function Address(i) {
        return address[i];
    }
    function Rooms(i) {
        return rooms[i];
    }
    function MaxGuests(i) {
        return maxNumbrOfGuests[i];
    }
    function Description(i) {
        return description[i]
    }

    
})(jQuery);