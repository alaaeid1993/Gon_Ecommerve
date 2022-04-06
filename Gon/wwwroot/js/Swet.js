
function n() {
    Swal.fire({
        icon: 'error',
        title: 'Oops...',
        text: 'Something went wrong!',
        footer: '<a href="">Why do I have this issue?</a>'
    })
}

//function add() {
//    Swal.fire({
//        position: 'top-end',
//        icon: 'success',
//        title: 'Product Added',
//        showConfirmButton: false,
//        timer: 1000
//    })
//}


function dele() {
    Swal.fire({
        title: 'ddd you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {


            Swal.fire(
                'Deleted!',
                'Your Recorded has been deleted.',
                'success'
            )


        }
    })
}



function add() {
    Swal.fire({
        toast: true,
        icon: 'success',
        title: 'Added successfully',
        animation: false,
        position: 'top-right',
        showConfirmButton: false,
        timer: 1000,
        timerProgressBar: true,
        didOpen: (toast) => {
            toast.addEventListener('mouseenter', Swal.stopTimer)
            toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
    })
}

