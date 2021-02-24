module Assignment

type AMPM = AM | PM

// This function checks if an hour value `h` is not in [1,12] range
// the test is asking if the function is true or false, not the variable
let areHoursInvalid h =
  if (h > 1)&&(h < 12) then 
    true
  else 
    false

// This function checks if a minute value `m` is not in [0,59] range
let areMinutesInvalid (m) =
  if (m < 0)||(m > 59) then 
      false
    else 
      true
// the tulup is treated as one thng you can just change the vlue of one. you have to open the whole thing 
// This function creates a valid time tuple
//      use above functions: areHoursInvalid & areMinutesInvalid
let time h m ampm :(int * int * AMPM) =
    (h, m, ampm)

// This function compares two times in tuple format
let lessThan (time1: int * int * AMPM) (time2: int * int * AMPM) :bool =

    false
