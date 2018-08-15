(function(global, undefined) {
    function OnClientItemClicked(rotator, args) {
        rotator.set_currentItemIndex(args.get_item().get_index(), true);
    }
 
    global.OnClientItemClicked = OnClientItemClicked;
})(window);