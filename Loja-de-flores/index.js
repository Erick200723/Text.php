function compra(){
   var formContainer = document.getElementById("formContainer");
   if(formContainer.style.display === 'none'){
    formContainer.style.display = 'block';
   }
   else{
    formContainer.style.display = 'none';
   }

}

function submit(){
    alert('Servidor cheio, tente novamente mas tarde');
}

function clearForm(){
    document.getElementById('contactForm').reset();
}