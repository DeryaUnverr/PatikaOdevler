const atlat = process.argv.slice(2)
const Pi=3.14;
function DaireAlanHesapla(yaricap)
{
 return yaricap*yaricap*Pi;
}
console.log( DaireAlanHesapla(atlat[0]*1))
