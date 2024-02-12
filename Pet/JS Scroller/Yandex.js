const registerbtn=document.querySelector('.registerbtn'),
vhodbtn=document.querySelector('.vhodbtn'),
formbox=document.querySelector('.form-box'),
body=document.querySelector('body');
registerbtn.onclick=function(){
    formbox.classList.add('active')
    body.classList.add('active')
};
vhodbtn.onclick=function(){
    formbox.classList.remove('active')
    body.classList.remove('active')
};