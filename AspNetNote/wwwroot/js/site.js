// Write your Javascript code.
$(".editor").trumbowyg({
    btnsDef: {
        image: {
            dropdown: ['insertImage', 'upload'],
            ico:'insertImage'
        }
    },
    btns: [
        ['viewHTML'],
        ['formatting'],       
        ['superscript', 'subscript'],
        ['link'],
        ['insertImage'],
        'image',
        'btnGrp-justify',
        'btnGrp-lists',
        ['horizontalRule'],
        ['removeformat'],
        ['fullscreen']
    ]
});
